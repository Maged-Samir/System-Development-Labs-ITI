var linkedList = {
    data: [],
    pushValue: function(value) {
        if (this.data.length > 0) {
            if (value < this.data[this.data.length - 1].value) {
                throw new Error('PLease Enter Value To Be Pushed');
            } else if (value == this.data[this.data.length - 1].value) {
                throw new Error('This Value is Exist ');
            }
        }
        this.data.push({value});
    },
    popValue: function() {
        if (this.data.length === 0) {
            throw new Error('Your List is Empty');
        }
        return this.data.splice(this.data.length - 1, 1)[0];
    },
    enqueValue: function(value) {
        if (this.data.length > 0) {
            if (value > this.data[0].value) {
                throw new Error('Please Display Values to Cheak Your Order');
            } else if (value === this.data[0].value) {
                throw new Error('This Value is Exist');
            }
        }
        this.data.unshift({value});
    },
    dequeValue: function() {
        if (this.data.length === 0) {
            throw new Error('Your List is Empty');
        }
        return this.data.splice(0, 1)[0];
    },
    display: function() {
        return this.data;
    },
    remove: function(value) {
        for (var i in this.data) {
            if (this.data[i].value == value) {
                this.data.splice(i, 1);
                return;
            }
        }
    },
    Add: function(value, index) {
        if (arguments.length == 1 && typeof value === 'number') {
            for (index = 0; index < this.data.length; index++) {
                if (this.data[index].value === value) {
                    throw new Error('This Value is Exist');
                }
                if (this.data[index].value > value) {
                    break;
                }
            }
        } else if (arguments.length == 2 && typeof value === 'number' && typeof index === 'number') {
            if ((!!this.data[index] && this.data[index].value > value) || (!!this.data[index+1] && this.data[index+1].value < value)) {
                throw new Error('invalid index, out of order');
            } else if (!!this.data[index] && this.data[index].value === value) {
                throw new Error('This Value is Exist');
            }
        } else {
            throw new Error('invalid parameters');
        }
        
        this.data.splice(index, 0, {value});
    }
}