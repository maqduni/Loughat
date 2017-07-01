using Loughat.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Raven.Client.Documents.Indexes;
using System.Linq;
using System.Linq.Expressions;
using Loughat.Entities.Enums;

namespace Loughat.Services.Indexes
{
    public class Cards_Search: AbstractIndexCreationTask<Card, Cards_Search.Result>
    {
        public static string Name() => typeof(Cards_Search).Name.Replace("_", "/");

        public class Result
        {
            public IEnumerable<string> Word { get; set; }
            public string Letter { get; set; }
            public CardType Type { get; set; }
            public int[] Pages { get; set; }
            public IEnumerable<string> Query { get; set; }
        }

        public class QueryProjection {
            public string Word { get; set; }
            public string Query { get; set; }
        }

        public Cards_Search()
        {
            Map = cards => from card in cards
                           let _wordList = card.Word.Fa.Concat(card.Word.Tj)
                           let _word = string.Join(" | ", _wordList)
                           let _definitionList = card.Definition.Fa.Concat(card.Definition.Tj)
                           //let _definition = string.Join(" | ", _definitionList)
                           let _letterList = card.Letter.Fa.Concat(card.Letter.Tj)
                           let _letter = string.Join(" | ", _letterList)
                           select new Result
                           {
                               Word = _wordList,
                               Letter = _letter,
                               Type = card.Type,
                               Pages = card.Pages,
                               Query = _wordList.Concat(_definitionList).Concat(_letterList)
                           };

            Index(x => x.Word, FieldIndexing.Analyzed);
            //Suggestion(x => x.Word);

            Index(x => x.Query, FieldIndexing.Analyzed);
            //Suggestion(x => x.Query);
            TermVector(x => x.Query, FieldTermVector.WithPositionsAndOffsets);
            
        }
    }
}
