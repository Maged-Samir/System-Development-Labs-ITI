

var clear;
var img=[]
 img=document.getElementsByTagName("img")
 var i=img.length-1
 var contain=document.getElementById("con");

 start()
function start()
{

    clear=setInterval(function(){
 if(i==img.length-1){
    img[i].src="marble1.jpg"
    img[0].src="marble3.jpg"
    i=0;
 }
 else{
     
      if(img[i].src="marble3.jpg")
      img[i].src="marble1.jpg"
      img[i+1].src="marble3.jpg"
      i++
 }

   

},1000)
}


function stop() {

   clearInterval(clear)
   
}











// contain.addEventListener('pointerover',stop)
// contain.removeEventListener('pointerleave',stop)
// contain.addEventListener('pointerleave',clear)









// var div=document.getElementById("div1");
// var imge=div.querySelectorAll("img");
// var i=0;
// var timemovement;
// imge[i].src="marble3.jpg"
// function movable()
// {
//     timemovement=setTimeout(movable,1000);
//     i++;
//     if(i<=5)
//     {
//         for(var j=0;j<imge.length;j++)
//         {
//             imge[j].src="marble1.jpg"
//         }
//         imge[i].src="marble3.jpg"

//     }
//     else
//     {
//         i=0;
//         imge[i].src="marble3.jpg"

//     }
// }

// imge[0].onmouseout=movable;
// imge[1].onmouseout=movable;
// imge[2].onmouseout=movable;
// imge[3].onmouseout=movable;
// imge[4].onmouseout=movable;

// function stopmoviment()
// {
//     clearTimeout(timemovement);
// }