function Box(width, height, material) {
    if (arguments.length < 2 || !Number.isInteger(width) || !Number.isInteger(height)) {
        throw new Error('Invalid dimensions');
    } else if (arguments.length < 3 || typeof material != 'string') {
        throw new Error('Invalid material');
    }

    this.height = height;
    this.width = width;
    this.material = material;
    this.content = [];
    this.length = 0;

    this.getHeight = function() {
        return this.height;
    };
    this.getWidth = function() {
        return this.width;
    };
    this.getMaterial = function() {
        return this.material;
    };
    this.getContent = function() {
        return this.content;
    };
    this.getLength = function() {
        this.count();
        return this.length;
    };
    this.count = function() {
        this.length = this.content.length;
    };

    this.setHeight = function(val) {
        if (isFinite(val)) {
            this.height = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setWidth = function(val) {
        if (isFinite(val)) {
            this.width = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.setMaterial = function(val) {
        if (typeof val == 'string') {
            this.material = val;
        } else {
            throw new Error("Invalid value");
        }
    };
    this.addBook = function(val) {
        if (val instanceof Book) {
            this.content.push(val);
        } else {
            throw new Error("Invalid value");
        }
    };
    this.removeBook = function(val) {
        if (typeof val == 'string') {
            for (var i = 0; i < this.content.length; i++) {
                if (this.content[i].title == val) {
                    var found = this.content[i];
                    
                    if (this.content[i].numOfCopies > 1) {
                        this.content[i].numOfCopies--;
                    } else {
                        this.content.splice(i, 1);
                    }

                    found.numOfCopies--;
                    return found;
                }
            }
        } else {
            throw new Error("Invalid value");
        }
    };

    this.valueOf = function() {
        return this.getLength();
    }

    this.toString = function() {
        return `width: ${this.width}
height: ${this.height}
content: ${this.content.toString()}`
    }

    Object.seal(this);
}