
var fruits=["apple","strawberry","banana","orange","mango"];

const CheckType = (t) => {return typeof t == "string"};
console.log(fruits.every(CheckType));

const CheakStartWithA = (element) => {return element[0]=="a"};
console.log(fruits.some(CheakStartWithA));


const Condition=(element) => element[0] === "b" || element[0] === "s";
console.log(fruits.filter(Condition));


const NewElemnts = (element) => {return `i like ${element}`};
console.log(fruits.map(NewElemnts));


const NewArray = fruits.map(NewElemnts)
NewArray.forEach(element => console.log(element));