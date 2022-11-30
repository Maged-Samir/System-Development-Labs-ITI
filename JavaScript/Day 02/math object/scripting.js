
function circle(radius)
{
    this.radius = radius;
  // area method
    this.area = function () 
    {
        return Math.PI * this.radius * this.radius;
    };
  
}


var r=parseInt(prompt('enter number'));
var c = new circle(r);
//console.log('Area =', c.area().toFixed(2));
var res=c.area().toFixed(2);

alert(`
total area of circle is : ${res} \n 
`);


function squareRoot(num)
{
    this.num = num;
  // area method
    this.squareRoot = function () 
    {
        return Math.sqrt(num);
    };
  
}


var r2=parseInt(prompt('enter number'));
var c2 = new squareRoot(r2);
//console.log('Area =', c.area().toFixed(2));
var res2=c2.squareRoot();

alert(`
SquareRoot of Your Number is  : ${res2} \n 
`);


function cosine(num)
{
    this.num = num;
  // area method
    this.cosine = function () 
    {
        return Math.cos((num * 3.14) / 180);
    };
  
}

var r3=parseInt(prompt('enter angel'));
var c3 = new cosine(r3);
//console.log('Area =', c.area().toFixed(2));
var res3=c3.cosine().toFixed(2);

alert(`
cos of your angel is  : ${res3} \n 
`);

document.write(`
cos of your angel is  : ${res3} \n 
`);