using Loughat.Entities;
using Loughat.Entities.Enums;
using Loughat.Entities.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Loughat.Tests
{
    public class Seed
    {
        public Seed()
        {
        }

        [Theory]
        public void GenerateAbbreviations()
        {
            // TODO: Figure out how to document the tajik text
            // TODO: Possibly just make it a simple dictionary
            // ИХТИСОРАҲО
            var abbreviations = new List<Abbreviation>()
            {
                new Abbreviation("а.", "арабӣ", true),
                new Abbreviation("адш.", "адабиётшиносӣ"),
                new Abbreviation("ак.", "аккадӣ"),
                new Abbreviation("анат.", "анатомия"),
                new Abbreviation("англ.", "англисӣ", true), // 'engleesy'
                new Abbreviation("асот.", "асотирӣ, асотиршиносӣ"),
                new Abbreviation("афс.", "афсонавӣ"),
                new Abbreviation("байт.", "байторӣ"),
                new Abbreviation("барқ.", "барқй, электрӣ"),
                new Abbreviation("баҳр.", "баҳрнавардӣ"),
                new Abbreviation("биол.", "биология"),
                new Abbreviation("богп.", "боғпарварӣ"),
                new Abbreviation("бот.", "ботаника"),
                new Abbreviation("боф.", "бофандагӣ"),
                new Abbreviation("ва ғ.", "ва ғайра"),
                new Abbreviation("ва м.ин.", "ва монанди ин"),
                new Abbreviation("варз.", "варзиш"),
                new Abbreviation("геол.", "геология"),
                new Abbreviation("грам.", "грамматика"),
                new Abbreviation("гуфт.", "гуфтугӯӣ"),
                new Abbreviation("д.", "динӣ"),
                new Abbreviation("дӯз.", "дӯзандагӣ"),
                new Abbreviation("зарб.", "зарбулмасал"),
                new Abbreviation("збш.", "забоншиносӣ"),
                new Abbreviation("зоол.", "зоология"),
                new Abbreviation("ибр.", "ибрӣ"),
                new Abbreviation("иқт.", "иқтисод"),
                new Abbreviation("исп.", "испанӣ", true),
                new Abbreviation("ит.", "италиявӣ", true),
                new Abbreviation("итт.", "иттилоотшиносӣ"),
                new Abbreviation("кайҳ.", "кайҳоннавардӣ"),
                new Abbreviation("кин.", "киноявӣ"),
                new Abbreviation("кит.", "китобӣ"),
                new Abbreviation("кишов.", "кишоварзӣ"),
                new Abbreviation("кҳн.", "кӯҳнашуда"),
                new Abbreviation("лаҳҷ.", "лаҳҷавӣ"),
                new Abbreviation("лот.", "лотинӣ", true),
                new Abbreviation("м.", "муғулӣ", true),
                new Abbreviation("мақ.", "мақол"),
                new Abbreviation("мал.", "малайзӣ", true),
                new Abbreviation("мант.", "мантиқ"),
                new Abbreviation("мас.", "масалан"),
                new Abbreviation("маҷ.", "маҷозан"),
                new Abbreviation("маъд.", "маъданшиносӣ"),
                new Abbreviation("меъ.", "меъморӣ"),
                new Abbreviation("мол.", "молия"),
                new Abbreviation("муқ.", "муқоиса шавад бо..."),
                new Abbreviation("муқоб.", "муқобили..."),
                new Abbreviation("мус.", "мусиқӣ"),
                new Abbreviation("нав.", "навсохт"),
                new Abbreviation("иашр.", "нашриёт"),
                new Abbreviation("ииг.", "нигаред ба..."),
                new Abbreviation("нум.", "нумератив"),
                new Abbreviation("нуҷ.", "илми нуҷум"),
                new Abbreviation("обҳш.", "обуҳавошиносӣ"),
                new Abbreviation("олм.", "олмонӣ", true),
                new Abbreviation("омӯз.", "омӯзгорӣ"),
                new Abbreviation("пасв.", "пасванд"),
                new Abbreviation("пешв.", "пешванд"),
                new Abbreviation("пол.", "поландӣ", true),
                new Abbreviation("порт.", "португалӣ", true),
                new Abbreviation("р.", "русӣ", true),
                new Abbreviation("радио.", "радиотехника"),
                new Abbreviation("риёз.", "риёзиёт, математика"),
                new Abbreviation("р.-оҳ.", "роҳи оҳан"),
                new Abbreviation("с.", "сиёсӣ"),
                new Abbreviation("санс.", "санскрит"),
                new Abbreviation("санъ.", "санъат"),
                new Abbreviation("сохт.", "сохтмон"),
                new Abbreviation("сур.", "суриёнй"),
                new Abbreviation("т.", "туркӣ", true),
                new Abbreviation("т.-м.", "туркию муғулӣ", true),
                new Abbreviation("таҳқ.", "сухани таҳқиромез"),
                new Abbreviation("таър.", "таърихӣ"),
                new Abbreviation("тех.", "техника"),
                new Abbreviation("тиб.", "тиббӣ"),
                new Abbreviation("тибет.", "тибетӣ"),
                new Abbreviation("фалс.", "фалсафа"),
                new Abbreviation("физ.", "физика"),
                new Abbreviation("фин.", "финландӣ"),
                new Abbreviation("фолк.", "фолклор"),
                new Abbreviation("фр.", "фаронсавӣ"),
                new Abbreviation("хим.", "химия"),
                new Abbreviation("хит.", "хитоӣ", true), // 'cheeny'
                new Abbreviation("хӯр.", "хӯрокворӣ"),
                new Abbreviation("ҳ.", "ҳиндӣ", true),
                new Abbreviation("ҳ.", "ҳарбӣ"),
                new Abbreviation("ҳанд.", "ҳандаса"),
                new Abbreviation("ҳисобд.", "ҳисобдорӣ"),
                new Abbreviation("ҳол.", "ҳолландӣ", true),
                new Abbreviation("ҳуқ.", "ҳуқуқшиносӣ"),
                new Abbreviation("ч.", "чехӣ", true),
                new Abbreviation("чорв.", "чорводорӣ"),
                new Abbreviation("ҷ.", "ҷамъи..."),
                new Abbreviation("ҷугр.", "ҷуғрофия"),
                new Abbreviation("ш.", "шаҳри..."),
                new Abbreviation("швед.", "шведӣ", true),
                new Abbreviation("ю.", "юнонӣ", true),
                new Abbreviation("я.", "яҳудӣ", true),
                new Abbreviation("яп.", "японӣ", true) // 'jopony'
            };

            //var abbrDict = abbreviations.ToDictionary(a => a.Short, a => a.Full);
            var serializedDict = JsonConvert.SerializeObject(abbreviations);
        }

        [Theory]
        public void GenerateAlphabet()
        {
            // TODO: Add pages 

            var aplhabet = new Alphabet()
            {
                Letters = new Dictionary<string, Definition>()
                {
                    { "А", new Definition(LanguageCode.Tj, "а") },
                    { "Б", new Definition(LanguageCode.Tj, "бе") },
                    { "В", new Definition(LanguageCode.Tj, "ве") },
                    { "Г", new Definition(LanguageCode.Tj, "ге") },
                    { "Ғ", new Definition(LanguageCode.Tj, "ғe") },
                    { "Д", new Definition(LanguageCode.Tj, "де") },
                    { "Е", new Definition(LanguageCode.Tj, "йе") },
                    { "Ё", new Definition(LanguageCode.Tj, "йо") },
                    { "Ж", new Definition(LanguageCode.Tj, "же") },
                    { "З", new Definition(LanguageCode.Tj, "зе") },
                    { "И", new Definition(LanguageCode.Tj, "и") },
                    { "Ӣ", new Definition(LanguageCode.Tj, "ӣ") },
                    { "Й", new Definition(LanguageCode.Tj, "ий") },
                    { "К", new Definition(LanguageCode.Tj, "ке") },
                    { "Қ", new Definition(LanguageCode.Tj, "қе") },
                    { "Л", new Definition(LanguageCode.Tj, "ле") },
                    { "М", new Definition(LanguageCode.Tj, "ме") },
                    { "Н", new Definition(LanguageCode.Tj, "не") },
                    { "О", new Definition(LanguageCode.Tj, "о") },
                    { "П", new Definition(LanguageCode.Tj, "пе") },
                    { "Р", new Definition(LanguageCode.Tj, "ре") },
                    { "С", new Definition(LanguageCode.Tj, "се") },
                    { "Т", new Definition(LanguageCode.Tj, "те") },
                    { "У", new Definition(LanguageCode.Tj, "у") },
                    { "Ӯ", new Definition(LanguageCode.Tj, "ӯ") },
                    { "Ф", new Definition(LanguageCode.Tj, "фе") },
                    { "Х", new Definition(LanguageCode.Tj, "хе") },
                    { "Ҳ", new Definition(LanguageCode.Tj, "ҳe") },
                    { "Ч", new Definition(LanguageCode.Tj, "че") },
                    { "Ҷ", new Definition(LanguageCode.Tj, "ҷе") },
                    { "Ш", new Definition(LanguageCode.Tj, "ше") },
                    { "Ъ", new Definition(LanguageCode.Tj, "ъ") },
                    { "Э", new Definition(LanguageCode.Tj, "э") },
                    { "Ю", new Definition(LanguageCode.Tj, "йу") },
                    { "Я", new Definition(LanguageCode.Tj, "йа") }
                }
            };

            var serializedAbc = JsonConvert.SerializeObject(aplhabet);
        }

        [Theory]
        public void LetterA()
        {
            var dictionary = new Dictionary()
            {
                Id = $"Dictionaries/{Guid.NewGuid()}", // TODO: Use Raven conventions to generate the id for new objects
                Name = "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
            };

            /*
             List of used tag:
             
            <abbr>
            <i>
            <b>

             */

            // Hold all cards in a List<Card>
            var cards = new List<Card>() {
                new Card() {
                    Id = $"Cards/{Guid.NewGuid()}", // TODO: Use Raven conventions to generate the id for new objects
                    Type = CardType.Letter,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition() {
                        Tj = "А"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            // TODO: Not everything is italic in the definition of the letter, review!!!
                            Tj = @"ҳарфи аввали алифбои ҳозираи тоҷикӣ; дар алифбои арабиасоси тоҷикӣ бо ҳарфҳои «алиф» (ا), «айн» (ع) ва дар охири як гурӯҳ калимаҳо бо «ҳои ҳавваз» (ه) ифода мешавад; ҳарфи «алиф» дар ҳисоби абҷад ба адади 1 баробар аст; ҳарфи «А» дар гурӯҳбандии синфҳои таълимӣ, табақабандии мавзӯъҳо ва <abbr>ғ.</abbr> ба ҷои шумораи якум ба кор меравад."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Suffix, // TODO: Verify whether ҳиссача is suffix
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "-А"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<i>ҳиссачаест, ки бо феъл омада, маънои</i> тааҷҷуб, таассуф, эҳсос, ҳаяҷон <i>ва гайраро ифода мекунад:</i> <b>чӣ гуфтед-а?, бахтро бинед-а!</b>"
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition() // TODO: Consider replacing the definition with a Dictionary<Enum.Language, string>
                    {
                        Tj = "ААМ(М)",
                        Fa = "اعم"
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> омтар, умумитар, фарогиртар; <b>аам аз он ки...</b> сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он"
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБ",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> падар, волид."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАВАЙН",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr>, <abbr>ҷ.</abbr> дугонаи аб; падару модар, волидайн."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАВИЯТ",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> падарӣ, падарӣ кардан."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАВИЯТ",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> падарӣ, падарӣ кардан."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАВИ",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> <i>мансуб ба</i> <b>аб</b>." // TODO: Add links to other words 
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАВОН",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> падару модар, волидайн."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАД",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>кит.</abbr> ҳамешагӣ, ҷовидон, доимӣ: <b>умри абад; то абад</b> ҳамеша, доим; <b>ҳабси абад</b> ҳабси якумрӣ, ҳабси доимӣ."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАДА",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>ҷ.</abbr> <b>обид; абадаи авсон</b> бутпарастон."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАДАН",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"ба таври ҳамешагӣ, ҷовидон."
                        },
                        new Definition()
                        {
                            Tj = @"ҳаргиз, ҳеҷ гоҳ, ҳеҷ вақт."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАДЗИНДА",
                        Fa = ""
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"ҷовидон, абадӣ, ҳамешазинда, ба таври ҳамешагй, фанонопазир."
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = 'А',
                    Pages = new int[] { 29 },
                    Word = new Definition()
                    {
                        Tj = "АБАДАН",
                        Fa = ""
                    },
                    Origin  = new Definition()
                    {
                        Tj = "<abbr lang=\"true\">a.</abbr>"
                    },
                    Definitions = new List<Definition>() {
                        new Definition()
                        {
                            Tj = @"<abbr>фалс.</abbr> ҷовидонӣ, пояндагӣ, фанонопазирӣ: <b>абадияти вақт, абадияти олам, абадияти ҳаракат.</b>"
                        }
                    },
                    Dictionary = dictionary.GetDenormalizedReference()
                }
            };

            var serializedList = JsonConvert.SerializeObject(cards);
        }
    }
}
