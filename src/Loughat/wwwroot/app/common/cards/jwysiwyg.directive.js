import './jwysiwyg.directive.scss';
// import * as XRegExp from 'xregexp';
// console.log(XRegExp);

export class JwysiwygDirective {
    constructor (lookupService) {
        'ngInject';

        this._lookupService = lookupService;

        this.restrict = 'A';
        this.require = 'ngModel';
    }
    
    link (scope, element, attrs, ctrl) {
        let ngModel = ctrl,
            jqElement = $(element),

            /**
             * Good RegExp explanation 
             * http://stackoverflow.com/questions/3512471/what-is-a-non-capturing-group-what-does-a-question-mark-followed-by-a-colon
             * http://breakthebit.org/post/3446894238/word-boundaries-in-javascripts-regular
             */
            reAbbrs,
            
            replaceBetween = (str, start, end, what) => {
                return str.substring(0, start) + what + str.substring(end);
            };
        
        //кит. омтар, умумитар, фарогиртар; адш. аам аз он ки... сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он ва ғ.

        this._lookupService.abbreviations().then((data) => {
            // console.log(data);
            var regexStr = `(?:^|[\\s\\n\\r\\t\.,\'"+!?-]+)(${
                    data.map((a) => { return a.Short.replace('.', '\\.').replace(' ', '\\s'); }).join('|')
                })(?:[\\s\\n\\r\\t\.,\'"+!?-]+|$)`;

            reAbbrs = new RegExp(regexStr, 'gmi');
            // console.log(reAbbrs);
        });
        

        ngModel.$render = () => {
            // console.log(ngModel, jqElement);
            jqElement.wysiwyg('setContent', ngModel.$modelValue);
        };

        jqElement.wysiwyg({
            autoSave: true,
            rmUnusedControls: true,
            controls: {
                bold: { visible: true },
                italic: { visible: true, css: { 'fontStyle': 'none' } },
                undo: { visible: true },
                redo: { visible: true },
                cut: { visible: true },
                copy: { visible: true },
                paste: { visible: true },
                abbr: { 
                    groupIndex: 0,
                    visible: true,
                    custom: true,
                    // tags: ['abbr'],
                    exec: function() {
                        /**
                         * This post is an absolute saviour
                         * http://stackoverflow.com/questions/280712/javascript-unicode-regexes
                         * 
                         * What are ranges?
                         * http://www.quirksmode.org/dom/range_intro.html
                         */
                        // window.ifr = this;

                        let body = this.innerDocument().body;

                        /**
                         * Remove all <attr> tags
                         * Interesting solution http://stackoverflow.com/questions/11890664/how-can-i-strip-certain-html-tags-out-of-a-string
                         */
                        let htmlTagRegex = /<[\/]{0,1}(abbr|ABBR)[^><]*>/ig;
                        body.innerHTML = body.innerHTML.replace(htmlTagRegex, '');

                        // Add <attr> tags back
                        // let bodyHtml = "кит. омтар, умумитар, фарогиртар; кит.  <b>аам аз он ки...</b> сарфи назар аз он ки..., бо вуҷуди он ки..., новобаста ба он кит. ",
                        let bodyHtml = body.innerHTML,
                            match,
                            matches = [];
                        while((match = reAbbrs.exec(bodyHtml)) !== null) {
                            let startPos = match.index + match[0].indexOf(match[1]);
                            let endPos = startPos + match[1].length;
                            // console.log(match, startPos, endPos);
                            matches.unshift({
                                match: match,
                                startPos: startPos,
                                endPos: endPos
                            });
                        }
                        
                        bodyHtml = matches.reduce((prev, curr) => {
                            let modifiedHtml = replaceBetween(prev, curr.startPos, curr.endPos, `<abbr>${curr.match[1]}</abbr>`);
                            return modifiedHtml;
                        }, bodyHtml);

                        ngModel.$setViewValue(bodyHtml);
                        ngModel.$render();
                    },
                    tooltip: 'Mark all abbreviations',
                    icon: 'public/assets/jquery.wysiwyg.gif'
                }
            },
            // TODO: Consider creating a separate css file to reduce the memory footprint
            css: 'public/app.css',
            events: {
                'input.wysiwyg': (event) => {
                    // console.log(event);
                    ngModel.$setViewValue(event.target.innerHTML);
                },
                'afterInit.wysiwyg': (event) => {
                    // TODO: Consider creating a separate css file to reduce the memory footprint
                    $(event.target.body).addClass('wysiwyg-iframe');
                }
            }
        });
    }

    //TODO: add destroy
}