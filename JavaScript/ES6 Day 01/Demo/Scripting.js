//////////////////////////////////////////////    Destructuring

// var arr = [1, 2, 3, 4, 5, 6, "a", "b", function () {}];

// var x = arr[0];
// var y = arr[1];
// var z = arr[6];
// var w = arr[8];

// var [x, y, z, , , , w, , , , h = 2] = arr;

// function fun() {
// // return [1, 2, 3, 4];
// // return "abcdefg";

// //not itrable -- will appeare errors in Destructuring
// return {name:'Ahmed',age:20}  

// }

// var [x,y,z]=fun();


// // Object Destructuring
// var MyObject={
//     name:'Mohamed',
//     age:22
// }

// // var x= MyObject.name;
// // var y= MyObject.age;

// var {name:x,age:y}=MyObject;


//////////////////////////////////////////////    Rest Parameter & Spread Operator

// function fun(x,y,z,...param){
// console.log(param);
// return x+y+z;
// }

// console.log(fun(1,2,3,4,5,6));
// // // ...Param is an array collect rest parameter of function



//Spread Operator

// var arr1=[1,2,3,4,5,6,7];
// var arr2=[8,9];

// // // Different Ways to Merge Two Arrays

// var arr3=[].concat(arr1,arr2);

// var arr1=[1,2,3,4,5,6,7];
// var arr2=[8,9,...arr1];


// // another Using For Spread Operator

// var array =["Ahmed","Mohamed"];

// function FullName(firstName,LastName){
//     return firstName + " "+ LastName;
// }

// FullName(array[0],array[1]);
// FullName(...array);





