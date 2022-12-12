function selectedImg(ID)
{
    for (var i=0 ; i<6 ; i++)
    {
       
        document.images[i].style.border="" ; 

    }
   document.getElementById(ID).style.border="solid 10px red";  


   setCookie("imageSrc" , ID); 
}


function generate_card()
{
    setCookie("Message" , document.getElementById("message").value);
    open("visitedpage.html","", "width =500 , height=500"); 
    
}

function typing()
{
   document.getElementById("image").src=getCookie("imageSrc"); 
   document.getElementById("para").innerHTML=getCookie("Message");
   
   
}


function closing()
{
    close("visitedpage");
}