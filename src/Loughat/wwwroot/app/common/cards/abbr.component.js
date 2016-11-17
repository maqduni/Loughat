export const AbbrComponent = {
    controller: class AbbrController {
        constructor($element, $attrs, lookupService) {
            this.lookupService = lookupService;
            this.$element = $element;

            // TODO: Configure eslint to ignore Reflect
            this.isLang = Reflect.ownKeys($attrs).indexOf('isLang') > -1;
            this.shortValue = $element.html();
        }

        $onInit() {
            this.abbreviations = this.isLang 
                ? this.lookupService.languageAbbreviations()
                : this.lookupService.abbreviations();
        }
        
        $postLink() {
            this.abbreviations.then((data) => {
                let abbr = data.find((i) => { return this.shortValue === i.Short; });
                if (abbr) this.$element.attr('title', abbr.Full);
            });
        }
    }
}