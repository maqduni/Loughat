export const AbbrEditComponent = {
    templateUrl: './app/common/cards/abbr-edit.component.html',
    require:{
        ngModel: 'ngModel'
    },
    controller: class AbbrEditController {
        constructor($element, $attrs, lookupService, $filter) {
            this.$element = $element;
            this.lookupService = lookupService;
            this.$filter = $filter;

            // TODO: Configure eslint to ignore Reflect
            this.isLang = Reflect.ownKeys($attrs).indexOf('isLang') > -1;
            this.shortValue = null;
        }

        $onInit() {
            this.abbreviations = this.isLang 
                ? this.lookupService.languageAbbreviations(true)
                : this.lookupService.abbreviations(true);

            this.ngModel.$formatters.push((modelValue) => {
                if (modelValue)
                    return this.$filter('htmlToPlainText')(modelValue);

                return null;
            });

            this.ngModel.$parsers.push((viewValue) => {
                if (viewValue)
                    return `<abbr${this.isLang ? ' is-lang' : ''}>${viewValue}</abbr>`;

                return null;
            });

            this.ngModel.$render = () => {
                this.shortValue = this.ngModel.$viewValue;
            };
        }
        
        updateViewValue() {
            this.ngModel.$setViewValue(this.shortValue);
        }

        $postLink() {
            
        }
    }
}