// import angular from 'angular';

export class LookupServiceMock {
    constructor($httpBackend, authServiceMock) {
        'ngInject'

        this.initData();
        this.configure($httpBackend, authServiceMock);
    }

    configure($httpBackend, authServiceMock) {
        authServiceMock.authorize($httpBackend.whenGET(/\/api\/lookup\/abbreviations/), (method, url, data, headers, params) => {
            let resData = this.abbreviations.filter((i) => { return !i.IsLanguageName; });
            return [200, resData];
        });

        authServiceMock.authorize($httpBackend.whenGET(/\/api\/lookup\/language-abbreviations/), (method, url, data, headers, params) => {
            let resData = this.abbreviations.filter((i) => { return i.IsLanguageName; });
            return [200, resData];
        });

        authServiceMock.authorize($httpBackend.whenGET(/\/api\/lookup\/alphabet/), (method, url, data, headers, params) => {
            let resData = this.alphabet;
            return [200, resData];
        });
    }

    initData() {
        this.usernames = ['irafiev@mail.ru', 'myself@angular.dev', 'devgal@angular.dev', 'devguy@angular.dev'];
        this.authToken = 'a76adc05-f23e-4309-b7e5-cdf0caef7dde';

        
        this.abbreviations = [
            {
                "Short": "а.",
                "Full": "арабӣ",
                "IsLanguageName": true
            },
            {
                "Short": "адш.",
                "Full": "адабиётшиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ак.",
                "Full": "аккадӣ",
                "IsLanguageName": false
            },
            {
                "Short": "анат.",
                "Full": "анатомия",
                "IsLanguageName": false
            },
            {
                "Short": "англ.",
                "Full": "англисӣ",
                "IsLanguageName": true
            },
            {
                "Short": "асот.",
                "Full": "асотирӣ, асотиршиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "афс.",
                "Full": "афсонавӣ",
                "IsLanguageName": false
            },
            {
                "Short": "байт.",
                "Full": "байторӣ",
                "IsLanguageName": false
            },
            {
                "Short": "барқ.",
                "Full": "барқй, электрӣ",
                "IsLanguageName": false
            },
            {
                "Short": "баҳр.",
                "Full": "баҳрнавардӣ",
                "IsLanguageName": false
            },
            {
                "Short": "биол.",
                "Full": "биология",
                "IsLanguageName": false
            },
            {
                "Short": "богп.",
                "Full": "боғпарварӣ",
                "IsLanguageName": false
            },
            {
                "Short": "бот.",
                "Full": "ботаника",
                "IsLanguageName": false
            },
            {
                "Short": "боф.",
                "Full": "бофандагӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ва ғ.",
                "Full": "ва ғайра",
                "IsLanguageName": false
            },
            {
                "Short": "ва м.ин.",
                "Full": "ва монанди ин",
                "IsLanguageName": false
            },
            {
                "Short": "варз.",
                "Full": "варзиш",
                "IsLanguageName": false
            },
            {
                "Short": "геол.",
                "Full": "геология",
                "IsLanguageName": false
            },
            {
                "Short": "грам.",
                "Full": "грамматика",
                "IsLanguageName": false
            },
            {
                "Short": "гуфт.",
                "Full": "гуфтугӯӣ",
                "IsLanguageName": false
            },
            {
                "Short": "д.",
                "Full": "динӣ",
                "IsLanguageName": false
            },
            {
                "Short": "дӯз.",
                "Full": "дӯзандагӣ",
                "IsLanguageName": false
            },
            {
                "Short": "зарб.",
                "Full": "зарбулмасал",
                "IsLanguageName": false
            },
            {
                "Short": "збш.",
                "Full": "забоншиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "зоол.",
                "Full": "зоология",
                "IsLanguageName": false
            },
            {
                "Short": "ибр.",
                "Full": "ибрӣ",
                "IsLanguageName": false
            },
            {
                "Short": "иқт.",
                "Full": "иқтисод",
                "IsLanguageName": false
            },
            {
                "Short": "исп.",
                "Full": "испанӣ",
                "IsLanguageName": true
            },
            {
                "Short": "ит.",
                "Full": "италиявӣ",
                "IsLanguageName": true
            },
            {
                "Short": "итт.",
                "Full": "иттилоотшиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "кайҳ.",
                "Full": "кайҳоннавардӣ",
                "IsLanguageName": false
            },
            {
                "Short": "кин.",
                "Full": "киноявӣ",
                "IsLanguageName": false
            },
            {
                "Short": "кит.",
                "Full": "китобӣ",
                "IsLanguageName": false
            },
            {
                "Short": "кишов.",
                "Full": "кишоварзӣ",
                "IsLanguageName": false
            },
            {
                "Short": "кҳн.",
                "Full": "кӯҳнашуда",
                "IsLanguageName": false
            },
            {
                "Short": "лаҳҷ.",
                "Full": "лаҳҷавӣ",
                "IsLanguageName": false
            },
            {
                "Short": "лот.",
                "Full": "лотинӣ",
                "IsLanguageName": true
            },
            {
                "Short": "м.",
                "Full": "муғулӣ",
                "IsLanguageName": true
            },
            {
                "Short": "мақ.",
                "Full": "мақол",
                "IsLanguageName": false
            },
            {
                "Short": "мал.",
                "Full": "малайзӣ",
                "IsLanguageName": true
            },
            {
                "Short": "мант.",
                "Full": "мантиқ",
                "IsLanguageName": false
            },
            {
                "Short": "мас.",
                "Full": "масалан",
                "IsLanguageName": false
            },
            {
                "Short": "маҷ.",
                "Full": "маҷозан",
                "IsLanguageName": false
            },
            {
                "Short": "маъд.",
                "Full": "маъданшиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "меъ.",
                "Full": "меъморӣ",
                "IsLanguageName": false
            },
            {
                "Short": "мол.",
                "Full": "молия",
                "IsLanguageName": false
            },
            {
                "Short": "муқ.",
                "Full": "муқоиса шавад бо...",
                "IsLanguageName": false
            },
            {
                "Short": "муқоб.",
                "Full": "муқобили...",
                "IsLanguageName": false
            },
            {
                "Short": "мус.",
                "Full": "мусиқӣ",
                "IsLanguageName": false
            },
            {
                "Short": "нав.",
                "Full": "навсохт",
                "IsLanguageName": false
            },
            {
                "Short": "иашр.",
                "Full": "нашриёт",
                "IsLanguageName": false
            },
            {
                "Short": "ииг.",
                "Full": "нигаред ба...",
                "IsLanguageName": false
            },
            {
                "Short": "нум.",
                "Full": "нумератив",
                "IsLanguageName": false
            },
            {
                "Short": "нуҷ.",
                "Full": "илми нуҷум",
                "IsLanguageName": false
            },
            {
                "Short": "обҳш.",
                "Full": "обуҳавошиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "олм.",
                "Full": "олмонӣ",
                "IsLanguageName": true
            },
            {
                "Short": "омӯз.",
                "Full": "омӯзгорӣ",
                "IsLanguageName": false
            },
            {
                "Short": "пасв.",
                "Full": "пасванд",
                "IsLanguageName": false
            },
            {
                "Short": "пешв.",
                "Full": "пешванд",
                "IsLanguageName": false
            },
            {
                "Short": "пол.",
                "Full": "поландӣ",
                "IsLanguageName": true
            },
            {
                "Short": "порт.",
                "Full": "португалӣ",
                "IsLanguageName": true
            },
            {
                "Short": "р.",
                "Full": "русӣ",
                "IsLanguageName": true
            },
            {
                "Short": "радио.",
                "Full": "радиотехника",
                "IsLanguageName": false
            },
            {
                "Short": "риёз.",
                "Full": "риёзиёт, математика",
                "IsLanguageName": false
            },
            {
                "Short": "р.-оҳ.",
                "Full": "роҳи оҳан",
                "IsLanguageName": false
            },
            {
                "Short": "с.",
                "Full": "сиёсӣ",
                "IsLanguageName": false
            },
            {
                "Short": "санс.",
                "Full": "санскрит",
                "IsLanguageName": false
            },
            {
                "Short": "санъ.",
                "Full": "санъат",
                "IsLanguageName": false
            },
            {
                "Short": "сохт.",
                "Full": "сохтмон",
                "IsLanguageName": false
            },
            {
                "Short": "сур.",
                "Full": "суриёнй",
                "IsLanguageName": false
            },
            {
                "Short": "т.",
                "Full": "туркӣ",
                "IsLanguageName": true
            },
            {
                "Short": "т.-м.",
                "Full": "туркию муғулӣ",
                "IsLanguageName": true
            },
            {
                "Short": "таҳқ.",
                "Full": "сухани таҳқиромез",
                "IsLanguageName": false
            },
            {
                "Short": "таър.",
                "Full": "таърихӣ",
                "IsLanguageName": false
            },
            {
                "Short": "тех.",
                "Full": "техника",
                "IsLanguageName": false
            },
            {
                "Short": "тиб.",
                "Full": "тиббӣ",
                "IsLanguageName": false
            },
            {
                "Short": "тибет.",
                "Full": "тибетӣ",
                "IsLanguageName": false
            },
            {
                "Short": "фалс.",
                "Full": "фалсафа",
                "IsLanguageName": false
            },
            {
                "Short": "физ.",
                "Full": "физика",
                "IsLanguageName": false
            },
            {
                "Short": "фин.",
                "Full": "финландӣ",
                "IsLanguageName": false
            },
            {
                "Short": "фолк.",
                "Full": "фолклор",
                "IsLanguageName": false
            },
            {
                "Short": "фр.",
                "Full": "фаронсавӣ",
                "IsLanguageName": false
            },
            {
                "Short": "хим.",
                "Full": "химия",
                "IsLanguageName": false
            },
            {
                "Short": "хит.",
                "Full": "хитоӣ",
                "IsLanguageName": true
            },
            {
                "Short": "хӯр.",
                "Full": "хӯрокворӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ҳ.",
                "Full": "ҳиндӣ",
                "IsLanguageName": true
            },
            {
                "Short": "ҳ.",
                "Full": "ҳарбӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ҳанд.",
                "Full": "ҳандаса",
                "IsLanguageName": false
            },
            {
                "Short": "ҳисобд.",
                "Full": "ҳисобдорӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ҳол.",
                "Full": "ҳолландӣ",
                "IsLanguageName": true
            },
            {
                "Short": "ҳуқ.",
                "Full": "ҳуқуқшиносӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ч.",
                "Full": "чехӣ",
                "IsLanguageName": true
            },
            {
                "Short": "чорв.",
                "Full": "чорводорӣ",
                "IsLanguageName": false
            },
            {
                "Short": "ҷ.",
                "Full": "ҷамъи...",
                "IsLanguageName": false
            },
            {
                "Short": "ҷугр.",
                "Full": "ҷуғрофия",
                "IsLanguageName": false
            },
            {
                "Short": "ш.",
                "Full": "шаҳри...",
                "IsLanguageName": false
            },
            {
                "Short": "швед.",
                "Full": "шведӣ",
                "IsLanguageName": true
            },
            {
                "Short": "ю.",
                "Full": "юнонӣ",
                "IsLanguageName": true
            },
            {
                "Short": "я.",
                "Full": "яҳудӣ",
                "IsLanguageName": true
            },
            {
                "Short": "яп.",
                "Full": "японӣ",
                "IsLanguageName": true
            }
        ];

        this.alphabet = {
            "Name": null,
            "Letters": {
                "А": {
                    "Tj": "а",
                    "Fa": null
                },
                "Б": {
                    "Tj": "бе",
                    "Fa": null
                },
                "В": {
                    "Tj": "ве",
                    "Fa": null
                },
                "Г": {
                    "Tj": "ге",
                    "Fa": null
                },
                "Ғ": {
                    "Tj": "ғe",
                    "Fa": null
                },
                "Д": {
                    "Tj": "де",
                    "Fa": null
                },
                "Е": {
                    "Tj": "йе",
                    "Fa": null
                },
                "Ё": {
                    "Tj": "йо",
                    "Fa": null
                },
                "Ж": {
                    "Tj": "же",
                    "Fa": null
                },
                "З": {
                    "Tj": "зе",
                    "Fa": null
                },
                "И": {
                    "Tj": "и",
                    "Fa": null
                },
                "Ӣ": {
                    "Tj": "ӣ",
                    "Fa": null
                },
                "Й": {
                    "Tj": "ий",
                    "Fa": null
                },
                "К": {
                    "Tj": "ке",
                    "Fa": null
                },
                "Қ": {
                    "Tj": "қе",
                    "Fa": null
                },
                "Л": {
                    "Tj": "ле",
                    "Fa": null
                },
                "М": {
                    "Tj": "ме",
                    "Fa": null
                },
                "Н": {
                    "Tj": "не",
                    "Fa": null
                },
                "О": {
                    "Tj": "о",
                    "Fa": null
                },
                "П": {
                    "Tj": "пе",
                    "Fa": null
                },
                "Р": {
                    "Tj": "ре",
                    "Fa": null
                },
                "С": {
                    "Tj": "се",
                    "Fa": null
                },
                "Т": {
                    "Tj": "те",
                    "Fa": null
                },
                "У": {
                    "Tj": "у",
                    "Fa": null
                },
                "Ӯ": {
                    "Tj": "ӯ",
                    "Fa": null
                },
                "Ф": {
                    "Tj": "фе",
                    "Fa": null
                },
                "Х": {
                    "Tj": "хе",
                    "Fa": null
                },
                "Ҳ": {
                    "Tj": "ҳe",
                    "Fa": null
                },
                "Ч": {
                    "Tj": "че",
                    "Fa": null
                },
                "Ҷ": {
                    "Tj": "ҷе",
                    "Fa": null
                },
                "Ш": {
                    "Tj": "ше",
                    "Fa": null
                },
                "Ъ": {
                    "Tj": "ъ",
                    "Fa": null
                },
                "Э": {
                    "Tj": "э",
                    "Fa": null
                },
                "Ю": {
                    "Tj": "йу",
                    "Fa": null
                },
                "Я": {
                    "Tj": "йа",
                    "Fa": null
                }
            }
        };

        // "А-а,Б-б,В-в,Г-г,Ғ-ғ,Д-д,Е-е,Ё-ё,Ж-ж,З-з,И-и,Ӣ-ӣ,Й-й,К-к,Қ-қ,Л-л,М-м,Н-н,О-о,П-п,Р-р,С-с,Т-т,У-у,Ӯ-ӯ,Ф-ф,Х-х,Ҳ-ҳ,Ч-ч,Ҷ-ҷ,Ш-ш,Ъ-ъ,Э-э,Ю-ю,Я-я"
    }
}