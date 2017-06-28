import angular from 'angular';
import { HtmlToPlainTextFilter } from './html-to-plain-text.filter'; 

export const FiltersModule = angular
    .module('app.filters', [])
    .filter('htmlToPlainText', HtmlToPlainTextFilter)
    .name;