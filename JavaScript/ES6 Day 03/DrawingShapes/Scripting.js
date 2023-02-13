class Shape
{
    constructor(Side=0){
        this.Side=Side;
    }

    toString() {
        return `Shape Side: ${this.Side}`;
      }
}

class Circle extends Shape
{
    constructor(Radius){
        super(Radius)
    }


    CalcArea(){
        return Math.PI*Math.pow(this.Side,2); 
    }

    toString() {
        return `Circle Radius: ${this.Side} , Area = ${this.CalcArea()}`;
      }
}

class Square extends Shape
{
    constructor(Side){
        super(Side)
    }

    CalcArea(){
        return Math.pow(this.Side,2); 
        }

    toString() {
        return `Square Side: ${this.Side} , Area = ${this.CalcArea()}`;
      }

}

class Rectangle extends Shape
{
    constructor(Height,Side){
        super(Side)
        this.Height=Height;
    }

    CalcArea(){
        return (this.Side)*(this.Height); 
        }

    toString() {
        return `Rectangle width: ${this.Side},height: ${this.Height} , Area = ${this.CalcArea()}`;
      }

}

class Triangle extends Shape
{
    constructor(Height,Side){
        super(Side)
        this.Height=Height;
    }

    CalcArea(){
        return 0.5*(this.Side)*(this.Height); 
        }

    toString() {
        return `Triangle base: ${this.Side},height: ${this.Height} , Area = ${this.CalcArea()}`;
      }

}



let canvas = document.querySelector("canvas");
let context = canvas.getContext("2d");
context.fillStyle = "red";
// context.fillRect(10, 10, 100, 50);




var S = new Square(500);
console.log(S.toString());
context.fillRect(10, 500, S.Side,S.Side);

var C = new Circle(100);
console.log(C.toString());
context.arc(1000, 150, C.Side, 0, 2 * Math.PI, false)
context.fill()
context.stroke()

var R = new Rectangle(400,700);
console.log(R.toString());
context.fillRect(10, 10, R.Side,R.Height);

var T = new Triangle(800,1000)
console.log(T.toString());
context.beginPath()
context.moveTo(T.Height, T.Height) // starting point
context.lineTo(T.Height, T.Side) // left side
context.lineTo(T.Side, T.Side) // hypotenuse / long side
context.fill() // closes the bottom side & fills
context.stroke()