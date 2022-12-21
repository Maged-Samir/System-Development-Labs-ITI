
function Sum() {
    if (arguments.length === 0) {
        throw new Error('zero arguments were passed');
    }
    var Sum = 0;
    for (var number of arguments) {
        if (typeof number != 'number') {
            throw new Error('Cheak Your PArameter Type');
        } else {
            Sum += number;
        }
    }
    
    return Sum;
}