// function findMinMax() {
//     array = [50, 60, 20, 10, 40];
//     minValue = Math.min(...array);
//     maxValue = Math.max(...array);
//     console.log(minValue);
//     console.log(maxValue);
// }

// findMinMax();


var x = [1, 2, 3, 4, 5, 6];
findMinMax(x);

function findMinMax(params) {
  minValue = Math.min(...params);
  maxValue = Math.max(...params);
  console.log(minValue);
  console.log(maxValue);
}