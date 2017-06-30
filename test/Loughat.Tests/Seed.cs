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

        [Fact]
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

        [Fact]
        public void GenerateAlphabet()
        {
            // TODO: Add pages 

            var aplhabet = new Alphabet()
            {
                Letters = new Dictionary<string, Definition>()
                {
                    { "А", "а".ToTj() },
                    { "Б", "бе".ToTj() },
                    { "В", "ве".ToTj() },
                    { "Г", "ге".ToTj() },
                    { "Ғ", "ғe".ToTj() },
                    { "Д", "де".ToTj() },
                    { "Е", "йе".ToTj() },
                    { "Ё", "йо".ToTj() },
                    { "Ж", "же".ToTj() },
                    { "З", "зе".ToTj() },
                    { "И", "и".ToTj() },
                    { "Ӣ", "ӣ".ToTj() },
                    { "Й", "ий".ToTj() },
                    { "К", "ке".ToTj() },
                    { "Қ", "қе".ToTj() },
                    { "Л", "ле".ToTj() },
                    { "М", "ме".ToTj() },
                    { "Н", "не".ToTj() },
                    { "О", "о".ToTj() },
                    { "П", "пе".ToTj() },
                    { "Р", "ре".ToTj() },
                    { "С", "се".ToTj() },
                    { "Т", "те".ToTj() },
                    { "У", "у".ToTj() },
                    { "Ӯ", "ӯ".ToTj() },
                    { "Ф", "фе".ToTj() },
                    { "Х", "хе".ToTj() },
                    { "Ҳ", "ҳe".ToTj() },
                    { "Ч", "че".ToTj() },
                    { "Ҷ", "ҷе".ToTj() },
                    { "Ш", "ше".ToTj() },
                    { "Ъ", "ъ".ToTj() },
                    { "Э", "э".ToTj() },
                    { "Ю", "йу".ToTj() },
                    { "Я", "йа".ToTj() }
                }
            };

            var serializedAbc = JsonConvert.SerializeObject(aplhabet);
        }

        [Fact]
        public void LetterA()
        {
            var dictionary = new Dictionary()
            {
                Id = $"Dictionaries/{Guid.NewGuid()}", // TODO: Use Raven conventions to generate the id for new objects
                Name = "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ".ToTj()
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
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "А".ToTj(),
                    // TODO: Not everything is italic in the definition of the letter, review!!!
                    Definition = @"ҳарфи аввали алифбои ҳозираи тоҷикӣ; дар алифбои арабиасоси тоҷикӣ бо ҳарфҳои «алиф» (ا), «айн» (ع) ва дар охири як гурӯҳ калимаҳо бо «ҳои ҳавваз» (ه) ифода мешавад; ҳарфи «алиф» дар ҳисоби абҷад ба адади 1 баробар аст; ҳарфи «А» дар гурӯҳбандии синфҳои таълимӣ, табақабандии мавзӯъҳо ва <abbr>ғ.</abbr> ба ҷои шумораи якум ба кор меравад.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Suffix, // TODO: Verify whether ҳиссача is suffix
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "-А".ToTj(),
                    Definition = @"<i>ҳиссачаест, ки бо феъл омада, маънои</i> тааҷҷуб, таассуф, эҳсос, ҳаяҷон <i>ва гайраро ифода мекунад:</i> <b>чӣ гуфтед-а?, бахтро бинед-а!</b>".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    // TODO: Consider replacing the definition with a Dictionary<Enum.Language, string>
                    Word = "ААМ(М)".ToTj().AddFa("اعم"),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> омтар, умумитар, фарогиртар; <b>аам аз он ки...</b> сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБ".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> падар, волид.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАВАЙН".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr>, <abbr>ҷ.</abbr> дугонаи аб; падару модар, волидайн.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАВИЯТ".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> падарӣ, падарӣ кардан.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАВИЯТ".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> падарӣ, падарӣ кардан.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАВИ".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    // TODO: Add links to other words 
                    Definition = @"<abbr>кит.</abbr> <i>мансуб ба</i> <b>аб</b>.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАВОН".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> падару модар, волидайн.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАД".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>кит.</abbr> ҳамешагӣ, ҷовидон, доимӣ: <b>умри абад; то абад</b> ҳамеша, доим; <b>ҳабси абад</b> ҳабси якумрӣ, ҳабси доимӣ.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАДА".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>ҷ.</abbr> <b>обид; абадаи авсон</b> бутпарастон.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАДАН".ToTj().AddFa(""),
                    Origin = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = new string[] {
                        @"ба таври ҳамешагӣ, ҷовидон.",
                        @"ҳаргиз, ҳеҷ гоҳ, ҳеҷ вақт."
                    }.ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАДЗИНДА".ToTj().AddFa(""),
                    Definition = @"ҷовидон, абадӣ, ҳамешазинда, ба таври ҳамешагй, фанонопазир.".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                },
                new Card()
                {
                    Type = CardType.Word,
                    Letter = "А".ToTj(),
                    Pages = new int[] { 29 },
                    Word = "АБАДАН".ToTj().AddFa(""),
                    Origin  = "<abbr lang=\"true\">a.</abbr>".ToTj(),
                    Definition = @"<abbr>фалс.</abbr> ҷовидонӣ, пояндагӣ, фанонопазирӣ: <b>абадияти вақт, абадияти олам, абадияти ҳаракат.</b>".ToTj(),
                    Dictionary = dictionary.GetDenormalizedReference()
                }
            };

            var serializedList = JsonConvert.SerializeObject(cards);
        }
    }
}
