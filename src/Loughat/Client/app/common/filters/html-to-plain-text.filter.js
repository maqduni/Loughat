export const HtmlToPlainTextFilter = () => {
    return (input) => {
        return input ? String(input).replace(/<[^>]+>/gm, '') : '';
    };
}