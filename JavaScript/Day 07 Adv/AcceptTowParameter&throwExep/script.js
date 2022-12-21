function Fun(a, b) {
    if (arguments.length != 2) {
        throw new Error('Plz Enter Only Two Param');
    }
}

Fun(2,3,5);