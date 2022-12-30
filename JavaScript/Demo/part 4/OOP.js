//JS is designed on a simple object-based paradim --> every thing is an object 
//JS is Multi-Paradigm programming language
//JS supports programming in many different styles 

//JS support OOP so it must have main principles of OOP 
//OOP --> classes - objects - inheritance - polymorphism - abstraction - encabsulation
// JS is Classless (Class-free) -- appeared in ES6

// Classes 
// in JS Class is a function  (function is an object)
// so there are different ways to create instance of class in js

//1-Factory Function

var AdditionFactoryFun =function(a){
    var x = a + 10 ;
    return x ;
}


// var employee =function (id,name){
//     var obj= 
//     {
//         empID:id,
//         empName:name
//     }
//     return obj;
// }


var employee = function (id,name){
    return{
        empId:id,
        empName:name
    }
}
var emp1= employee("1","Ahmed");

emp1.address="Cairo";

//Ctor Pattern

/**
 *     Class Person                         ////////////////
 *      {                                   ////////////////
 *          var person =function(id,name)
 *          {
 *              this.personID=id 
 *              this.personName=name
 *          }
 *      }                                   ////////////////
 */

var person = function (id,name){

    this.personID=id
    this.personName=name

    // this.show=function(){
    //     return this.personID + '---' +this.personName
    // }
    this.show=display;

}

//Shared Function Pattern
var display =this.show=function(){
        return this.personID + '---' +this.personName
    }

var per1 = new person(5,'Mona');