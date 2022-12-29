var x=10;

function OuterFun(a){
    var y=20;
    //var x=20;   ---->Shadwing
    var InnerFun=function(b){
        var z = 30;
        return x + y + z + a + b ; //---->Scope Chining
    }

    return InnerFun(1)
}

console.log(OuterFun(1)); 

// Execute OuterFun(1) --> 
   //Hoisting var Y,Innerfun
   //Execute  InnerFun(1) 
   //Hoisting var Z 
   //Return x y z a b ---> 62 

//Closure is not a scope , we have only three scopes 
// local , global and block scope 
//so Closure is a concept not a block occared when we have inner fun 
// inside outer function and this fun (inner) need parameters from outer


////////////////////////////////////////////////////////

 function ArrPushFun(){ //arr=[fn ,fn ,fn], i=3
    var arr =[];

    for(var i=0;i<3;i++){
        arr.push(function(){
            console.log(i);
        })
    }
    return arr;
 }
var result= ArrPushFun();

console.log(result);
console.log(result[0]())
console.log(result[1]())
console.log(result[2]())
//the problem here is the value of i will be with the last value of i-->3


// to solve this problem , we need to narrow our scope 
// use IIFE Function
function ArrPushFun(){ //arr=[fn ,fn ,fn], i=3
    var arr =[];
    
    for(var i=0;i<3;i++){
        arr.push(function(i){
             
            return function(){
                console.log(i);
            }
        }(i)) //IIFE DP 
              //Immediately Invoked Function Expression
    }
    return arr;
 }
var result= ArrPushFun();

console.log(result);
console.log(result[0]())
console.log(result[1]())
console.log(result[2]())