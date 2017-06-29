using Loughat.Entities.Enums;
using Loughat.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loughat.Entities
{
    public class Card: IEntity
    {
        /// <summary>
        /// Unique id representing the object
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Reference to the dictioanry object
        /// </summary>
        public DenormalizedReference Dictionary { get; set; }

        /// <summary>
        /// The letter, word or phrase
        /// </summary>
        public Definition Word { get; set; }

        /// <summary>
        /// Abbreviation of the origin of the word
        /// </summary>
        public Definition Origin { get; set; }

        /// <summary>
        /// Word definition with the list of word meanings
        /// </summary>
        public Definition Definition { get; set; }

        /// <summary>
        /// The first letter of the word
        /// </summary>
        public char Letter { get; set; }
        
        /// <summary>
        /// The number of the page(s) of the dictionary the letter, word, or phrase appears on
        /// </summary>
        public int[] Pages { get; set; }
        
        /// <summary>
        /// Type of lexical structure: letter, word, phrase, prefix, or suffix
        /// </summary>
        public CardType Type { get; set; }

        /// <summary>
        /// List of verses where the word is used
        /// </summary>
        public List<Verse> Verses { get; set; }
    }
}
