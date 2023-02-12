// function SwapValues(x,y){
//     var temp;
//     temp=x;
//     x=y
//     y=temp;
//     return [x,y];
// }
// console.log(SwapValues(2,3));



var arr=[2,3];
function SwapValuesUsingDestructuring(){
    var [b,a]=arr;
    return [a,b];
}
console.log(SwapValuesUsingDestructuring());