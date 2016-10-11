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
                new Abbreviation("а.", "арабӣ"),
                new Abbreviation("адш.", "адабиётшиносӣ"),
                new Abbreviation("ак.", "аккадӣ"),
                new Abbreviation("анат.", "анатомия"),
                new Abbreviation("англ.", "англисӣ"),
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
                new Abbreviation("исп.", "испанӣ"),
                new Abbreviation("ит.", "италиявӣ"),
                new Abbreviation("итт.", "иттилоотшиносӣ"),
                new Abbreviation("кайҳ.", "кайҳоннавардӣ"),
                new Abbreviation("кин.", "киноявӣ"),
                new Abbreviation("кит.", "китобӣ"),
                new Abbreviation("кишов.", "кишоварзӣ"),
                new Abbreviation("кҳн.", "кӯҳнашуда"),
                new Abbreviation("лаҳҷ.", "лаҳҷавӣ"),
                new Abbreviation("лот.", "лотинӣ"),
                new Abbreviation("м.", "муғулӣ"),
                new Abbreviation("мақ.", "мақол"),
                new Abbreviation("мал.", "малайзӣ"),
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
                new Abbreviation("олм.", "олмонӣ"),
                new Abbreviation("омӯз.", "омӯзгорӣ"),
                new Abbreviation("пасв.", "пасванд"),
                new Abbreviation("пешв.", "пешванд"),
                new Abbreviation("пол.", "поландӣ"),
                new Abbreviation("порт.", "португалӣ"),
                new Abbreviation("р.", "русӣ"),
                new Abbreviation("радио.", "радиотехника"),
                new Abbreviation("риёз.", "риёзиёт, математика"),
                new Abbreviation("р.-оҳ.", "роҳи оҳан"),
                new Abbreviation("с.", "сиёсӣ"),
                new Abbreviation("санс.", "санскрит"),
                new Abbreviation("санъ.", "санъат"),
                new Abbreviation("сохт.", "сохтмон"),
                new Abbreviation("сур.", "суриёнй"),
                new Abbreviation("т.", "туркӣ"),
                new Abbreviation("т.-м.", "туркию муғулӣ"),
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
                new Abbreviation("хит.", "хитоӣ"),
                new Abbreviation("хӯр.", "хӯрокворӣ"),
                new Abbreviation("ҳ.", "ҳиндӣ"),
                new Abbreviation("ҳ.", "ҳарбӣ"),
                new Abbreviation("ҳанд.", "ҳандаса"),
                new Abbreviation("ҳисобд.", "ҳисобдорӣ"),
                new Abbreviation("ҳол.", "ҳолландӣ"),
                new Abbreviation("ҳуқ.", "ҳуқуқшиносӣ"),
                new Abbreviation("ч.", "чехӣ"),
                new Abbreviation("чорв.", "чорводорӣ"),
                new Abbreviation("ҷ.", "ҷамъи..."),
                new Abbreviation("ҷугр.", "ҷуғрофия"),
                new Abbreviation("ш.", "шаҳри..."),
                new Abbreviation("швед.", "шведӣ"),
                new Abbreviation("ю.", "юнонӣ"),
                new Abbreviation("я.", "яҳудӣ"),
                new Abbreviation("яп.", "японӣ")
            };

            var abbrDict = abbreviations.ToDictionary(a => a.Short, a => a.Full);
            var serializedDict = JsonConvert.SerializeObject(abbrDict);
        }

        [Theory]
        public void GenerateAlphabet()
        {
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
                    { "И", new Definition(LanguageCode.Tj, "И") },
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

            var card1 = new Card() {
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
            };

            var card2 = new Card()
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
            };

            var card3 = new Card()
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
                    Tj = "a." // TODO: Possibly point directly to the abbreviation
                },
                Definitions = new List<Definition>() {
                    new Definition()
                    {
                        Tj = @"<abbr>кит.</abbr> омтар, умумитар, фарогиртар; <b>аам аз он ки...</b> сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он"
                    }
                },
                Dictionary = dictionary.GetDenormalizedReference()
            };
        }
    }
}
