export const AppComponent = {
    template: `
        <header>
            Hello world
            <login></login>
        </header>
        <div>
            <div ui-view></div>
        </div>
        <footer>
            Copyright MyApp 2016.
        </footer>
    `
    ,
    controller: function () {
        // console.log('App Ctrl', this);
    }
};