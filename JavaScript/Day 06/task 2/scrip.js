var moveImg = document.body.firstElementChild.firstElementChild; 

moveImg.style.textAlign= "right";



var newDiv= document.createElement("div");         
document.body.firstElementChild.append(newDiv);    

var newImg= document.createElement("img");        
newImg.src="dom.jpg";                       

newDiv.append(newImg);                     


newDiv.style.textAlign="left";   


var changeCircle = document.body.firstElementChild.firstElementChild.nextElementSibling.firstElementChild;
changeCircle.style="list-style-type:circle" ;  
