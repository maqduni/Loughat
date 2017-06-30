using Loughat.Entities;
using Loughat.Entities.Enums;
using Loughat.Entities.Extensions;
using Loughat.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace Loughat.Tests
{
    public class DictionaryPage
    {
        public string Page { get; set; }
        public string Tab { get; set; }
    }

    public class Parser
    {
        public Parser()
        {

        }

        [Fact]
        public void Playground()
        {
            var test = @"-39";
            var page_match = Regex.Match(test, @"\d+");

            Store.ExecuteIndexCreationTasks();
        }

        [Fact]
        public void ParsePageInPlainText()
        {
            // Read the source file
            var filePath = @"Z:\Desktop\Farhang\Jild 1 Text\Pages\02x_03x.txt";
            var fileLines = File.ReadAllLines(filePath);

            // TODO: There are examples of when origin abbreviations are used in pairs, ю.-лот.
            // TODO: There are a lot of examples where кит. is written before the first meaning in definitions with multiple meanings
            // TODO: Keep Origin? Or combine it with the preliminary descripption of the word?

            // Setup regexp to parse the word line (test @http://regexr.com/)
            // - Word (tajik uppercase literals with dashes and parentheses)
            // - Definition number # (latin figure)
            // - Origin (a language abbreviation)
            // - Definition
            string r_Word = @"[АБВГҒДЕЁЖЗИӢЙКҚЛМНОПРСТУӮФХҲЧҶШЪЭЮЯ\-\(\)]+",
                r_Num = @"[IVX]+",
                r_Origin = @"а\.|англ\.|исп\.|ит\.|лот\.|м\.|мал\.|олм\.|пол\.|порт\.|р\.|т\.|т\.-м\.|хит\.|ҳ\.|ҳол\.|ч\.|швед\.|ю\.|я\.|яп\.",
                r_Definition = @".+";
            var regexp = new Regex($@"^({r_Word})+\s+({r_Num})?\s?({r_Origin})?\s?({r_Definition})");

            
            // Setup loop variables
            var dict_Pages = new List<DictionaryPage>();
            var page = new DictionaryPage();
            var dict_Words = new List<Card>();
            var emptyLineCounter = 0;
            foreach (var line in fileLines)
            {
                // Page info is on the first 7 lines
                if (emptyLineCounter < 8)
                {
                    switch (emptyLineCounter)
                    {
                        // Page number
                        case 2:
                            var page_match = Regex.Match(line, @"\d+");
                            if (page_match.Success)
                            {
                                dict_Pages.Add(new DictionaryPage { Page = page_match.Value, Tab = null });
                            }
                            else
                            {
                                dict_Pages.Add(new DictionaryPage { Page = "-1", Tab = line });
                            }
                            break;
                        // Page tab
                        case 5:
                            page = dict_Pages.Last();
                            if (page.Tab == null)
                            {
                                page.Tab = line;
                            }
                            else
                            {
                                page_match = Regex.Match(line, @"\d+");
                                page.Page = page_match.Success ? page_match.Value : "-1";
                            }
                            break;
                        default:
                            break;
                    }
                    emptyLineCounter++;
                    continue;
                }

                // Empty line indicates new page
                if (string.IsNullOrEmpty(line))
                {
                    emptyLineCounter = 1;
                    continue;
                }

                // Parse the word
                var match = regexp.Match(line);
                var card = new Card()
                {
                    Word = match.Groups[1].Value.ToTj(),
                    Origin = match.Groups[2].Value.ToTj(),
                    Definition = Regex.Split(match.Groups[4].Value, @"\d\s*\.\s*")
                    .ToArray().ToTj(),
                    
                    Letter = page.Tab.Substring(0, 1).ToTj(),
                    Pages = new int[] { int.Parse(page.Page) },
                    Type = 
                    match.Groups[1].Value.StartsWith("-") ? CardType.Suffix : 
                    match.Groups[1].Value.EndsWith("-") ? CardType.Prefix : 
                    CardType.Word
                };

                dict_Words.Add(card);
            }

            var serializedPages = JsonConvert.SerializeObject(dict_Pages);
            var serializedWords = JsonConvert.SerializeObject(dict_Words);

            using (var bulkInsert = Store.Documents.BulkInsert())
            {
                foreach (var card in dict_Words)
                {
                    bulkInsert.Store(card);
                }
            }
        }
    }
}
