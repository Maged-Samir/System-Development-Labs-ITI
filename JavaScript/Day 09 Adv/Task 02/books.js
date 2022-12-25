function Book (title, numOfChapters, author, numOfPages, publisher, numOfCopies) {
    if (arguments.length != 6 || typeof title != 'string' || !Number.isInteger(numOfChapters) ||
        typeof author != 'string' || !Number.isInteger(numOfPages) || typeof publisher != 'string' ||
        !Number.isInteger(numOfCopies)) {

            throw new Error('Invalid arguments');
        }

    this.title = title;
    this.author = author;
    this.numOfChapters = numOfChapters;
    this.publisher = publisher;
    this.numOfCopies = numOfCopies;
    this.numOfPages = numOfPages;

    this.getTitle = function() {
        return this.title;
    };
    this.getNumOfChapters = function() {
        return this.numOfChapters;
    };
    this.getAuthor = function() {
        return this.author;
    };
    this.getNumOfPages = function() {
        return this.numOfPages;
    };
    this.getPublisher = function() {
        return this.publisher;
    };
    this.getNumOfCopies = function() {
        return this.numOfCopies;
    };


    this.setNumOfChapters = function(val) {
        if (Number.isInteger(val)) {
            this.numOfChapters = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setAuthor = function(val) {
        if (typeof val == 'string') {
            this.author = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setTitle = function(val) {
        if (typeof val == 'string') {
            this.title = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setNumOfPages = function(val) {
        if (Number.isInteger(val)) {
            this.numOfPages = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setAuthor = function(val) {
        if (typeof val == 'string') {
            this.author = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setPublisher = function(val) {
        if (typeof val == 'string') {
            this.publisher = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setNumOfCopies = function(val) {
        if (Number.isInteger(val)) {
            this.numOfCopies = val;
        } else {
            throw new Error("Invalid value");
        }
    };

    this.toString = function() {
        return this.title;
    };

    Object.seal(this);
    Object.freeze(this);
}