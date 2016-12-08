export const AbbrEditComponent = {
    templateUrl: './app/common/cards/abbr-edit.component.html',
    require:{
        ngModel: 'ngModel'
    },
    controller: class AbbrEditController {
        constructor($element, $attrs, lookupService, $filter) {
            this._$element = $element;
            this._lookupService = lookupService;
            this._$filter = $filter;

            // TODO: Configure eslint to ignore Reflect
            this.isLang = Reflect.ownKeys($attrs).indexOf('isLang') > -1;
            this.shortValue = null;
        }

        $onInit() {
            this.abbreviations = this.isLang 
                ? this._lookupService.languageAbbreviations(true)
                : this._lookupService.abbreviations(true);

            this.ngModel.$formatters.push((modelValue) => {
                if (modelValue)
                    return this._$filter('htmlToPlainText')(modelValue);

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

            // console.log(this._lookupService.abbreviations(true));
        }

        $postLink() {
            
        }
    }
}