import './virtkeys.directive.scss';

export class VirtkeysDirective {
    constructor () {
        this.restrict = 'A';
        this.require = 'ngModel';
    }
    
    link (scope, element, attrs, ctrl) {
        let opts = { showKeyboardMaps: false },
            kb = $('body').find('> .virtual-keyboard').virtkeys(opts),
            layouts = {};
        if (kb.length === 0) {
            kb = $('<div class="virtual-keyboard"></div>').virtkeys(opts);
            
            layouts = kb.getLoadedLayouts();
            kb.addLayouts(layouts['TG'].filter((l) => { return l.name.indexOf('Cyrillic') > -1 }));
            kb.addLayouts(layouts['FA-IR']);

            $('body').append(kb);
        }

        let lang = attrs.lang,
            langMap = {
            'tj': 'TG Tajik Cyrillic',
            'fa': 'IR Farsi'
        };

        // Define event listeners
        element.on('focus', () => {
            kb.close();
            kb.open(element[0]);
            kb.switchLayout(langMap[lang]);
        });
    }
}