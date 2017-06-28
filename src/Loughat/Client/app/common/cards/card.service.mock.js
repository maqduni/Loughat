export class CardServiceMock {
    constructor($httpBackend, authServiceMock) {
        'ngInject'

        this.initData();
        this.configure($httpBackend, authServiceMock);
    }

    configure($httpBackend, authServiceMock) {
        $httpBackend.whenGET(/\/api\/search\?term=.*&start=\d*&pageSize=\d*/).respond((method, url, data, headers, params) => {
            // console.log(params);
            if (!params.term)
                return [200, this.cards];
            
            var cards = this.cards.filter((c) => {
                return ~c.Word.Tj.indexOf(params.term);
            })
            return [200, cards];
        });

        // authServiceMock.authorize($httpBackend.whenPOST(`\/api\/account\/test`), (method, url, data, headers, params) => {
        //     return [200, 'Auth header and token test passed'];
        // });
    }

    initData() {
        this.cards = [
            {
                "Id": "Cards/196fcfbe-aac9-4cff-8a09-b885a7478634",
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 0,
                "Word": {
                    "Tj": "А",
                    "Fa": null
                },
                "Origin": null,
                "Definitions": [
                    {
                        "Tj": "ҳарфи аввали алифбои ҳозираи тоҷикӣ; дар алифбои арабиасоси тоҷикӣ бо ҳарфҳои «алиф» (ا), «айн» (ع) ва дар охири як гурӯҳ калимаҳо бо «ҳои ҳавваз» (ه) ифода мешавад; ҳарфи «алиф» дар ҳисоби абҷад ба адади 1 баробар аст; ҳарфи «А» дар гурӯҳбандии синфҳои таълимӣ, табақабандии мавзӯъҳо ва <abbr>ғ.</abbr> ба ҷои шумораи якум ба кор меравад.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 4,
                "Word": {
                    "Tj": "-А",
                    "Fa": null
                },
                "Origin": null,
                "Definitions": [
                    {
                        "Tj": "<i>ҳиссачаест, ки бо феъл омада, маънои</i> тааҷҷуб, таассуф, эҳсос, ҳаяҷон <i>ва гайраро ифода мекунад:</i> <b>чӣ гуфтед-а?, бахтро бинед-а!</b>",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "ААМ(М)",
                    "Fa": "اعم"
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> омтар, умумитар, фарогиртар; <b>аам аз он ки...</b> сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБ",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> падар, волид.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАВАЙН",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr>, <abbr>ҷ.</abbr> дугонаи аб; падару модар, волидайн.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАВИЯТ",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> падарӣ, падарӣ кардан.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАВИЯТ",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> падарӣ, падарӣ кардан.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАВИ",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> <i>мансуб ба</i> <b>аб</b>.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАВОН",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> падару модар, волидайн.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАД",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>кит.</abbr> ҳамешагӣ, ҷовидон, доимӣ: <b>умри абад; то абад</b> ҳамеша, доим; <b>ҳабси абад</b> ҳабси якумрӣ, ҳабси доимӣ.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАДА",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>ҷ.</abbr> <b>обид; абадаи авсон</b> бутпарастон.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАДАН",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "ба таври ҳамешагӣ, ҷовидон.",
                        "Fa": null
                    },
                    {
                        "Tj": "ҳаргиз, ҳеҷ гоҳ, ҳеҷ вақт.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАДЗИНДА",
                    "Fa": ""
                },
                "Origin": null,
                "Definitions": [
                    {
                        "Tj": "ҷовидон, абадӣ, ҳамешазинда, ба таври ҳамешагй, фанонопазир.",
                        "Fa": null
                    }
                ],
                "Verses": null
            },
            {
                "Id": null,
                "Letter": "А",
                "Pages": [
                    29
                ],
                "Dictionary": {
                    "Id": "Dictionaries/46b91137-33f9-40f4-ac03-8249d98abf8d",
                    "Name": "ФАРҲАНГИ ТАФСИРИИ ЗАБОНИ ТОҶИКӢ"
                },
                "Type": 1,
                "Word": {
                    "Tj": "АБАДАН",
                    "Fa": ""
                },
                "Origin": {
                    "Tj": "<abbr is-lang>а.</abbr>",
                    "Fa": null
                },
                "Definitions": [
                    {
                        "Tj": "<abbr>фалс.</abbr> ҷовидонӣ, пояндагӣ, фанонопазирӣ: <b>абадияти вақт, абадияти олам, абадияти ҳаракат.</b>",
                        "Fa": null
                    }
                ],
                "Verses": null
            }
        ];
    }
}