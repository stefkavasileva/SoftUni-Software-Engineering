(function () {
    class Cat {
        constructor(id, statusCode, statusMessage, imageLocation) {
            this.id = id;
            this.statusCode = statusCode;
            this.statusMessage = statusMessage;
            this.imageLocation = imageLocation;
        }
    }

    let cats = [
        new Cat('100', 100, 'Continue', 'cat100'),
        new Cat('200', 200, 'Ok', 'cat200'),
        new Cat('204', 204, 'No content', 'cat204'),
        new Cat('301', 301, 'Moved permanently', 'cat301'),
        new Cat('304', 304, 'Not modified', 'cat304'),
        new Cat('400', 400, 'Bad request', 'cat400'),
        new Cat('404', 404, 'Not Found', 'cat404'),
        new Cat('406', 406, 'Not Acceptable', 'cat406'),
        new Cat('410', 410, 'Gone', 'cat410'),
        new Cat('500', 500, 'Internal Server Error', 'cat500'),
        new Cat('511', 500, 'Network Authentication Required', 'cat511')
    ];

    window.cats = cats;
})()