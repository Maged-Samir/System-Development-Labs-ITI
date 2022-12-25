function myList(start, end, step) {

    if (arguments.length == 1 && Number.isInteger(start)) {
        end = start;
        start = 0;
        step = 1;
    } else if (arguments.length == 2 && Number.isInteger(start) && Number.isInteger(end)) {
        step = 1;
    } else if (arguments.length == 3 && Number.isInteger(start) && Number.isInteger(end) && Number.isInteger(step)) {
    } else {
        throw new Error('Invalid arguments');
    }

    
    Object.defineProperty(this, 'array', {
        value: [],
        enumerable:false,
        writable:false,
        configurable:false
    });
    
    this.step = step;

    for (var i = start; i < end; i += step) {
        this.array.push(i);
    }

    this.getmyList = function() {
        return this.array;
    };

    this.setmyList = function(newArray) {
        for (var i = 0; i < newArray.length; i++) {
            if (!Number.isInteger(newArray[i])) {
                throw new Error('Sequence must consist only of integers')
            }
        }

        this.step = newArray.length > 1 ? newArray[1] - newArray[0] : 1;

        for (var i = 0; i < newArray.length - 1; i++) {
            if (this.step > 0) {
                if (newArray[i] >= newArray[i+1]) {
                    throw new Error('Invalid sequence');
                }
            } else {
                if (newArray[i] <= newArray[i+1]) {
                    throw new Error('Invalid sequence');
                }
            }
        }

        this.array = newArray;
    }

    this.append = function (val) {
        if (!Number.isInteger(val)) {
            throw new Error('Sequence must consist only of integers');
        } else if (this.array.length != 0 && val - this.array[this.array.length - 1] != step) {
            throw new Error('Value does not belong to the sequence');
        } else {
            this.array.push(val);
        }
    }
    
    this.prepend = function (val) {
        if (!Number.isInteger(val)) {
            throw new Error('Sequence must consist only of integers');
        } else if (this.array.length != 0 && this.array[0] - val != step) {
            throw new Error('Value does not belong to the sequence');
        } else {
            this.array.unshift(val);
        }
    }

    this.pop = function() {
        return this.array.pop();
    }

    this.dequeue = function() {
        return this.array.splice(0, 1);
    }
}

myList.prototype.toString = function() {
    return this.array.toString();
}