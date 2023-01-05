function changeColor(){
    var red=document.getElementById("R").value;
    var green=document.getElementById("G").value;
    var blue=document.getElementById("B").value;
    var color='rgb('+red +','+green+','+blue+')';

    document.getElementsByTagName("p")[0].style.color=color;
}