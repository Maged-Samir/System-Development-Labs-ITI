function setCookie(cookieName,cookieValue,expiryDate)
{
   if (expiryDate)
   {
    document.cookie=cookieName + "=" + cookieValue + "; expires =" +  expiryDate.toGMTString();
   }

  else
  {
     document.cookie=cookieName + "=" +cookieValue;
  }


}

function getCookie(cookieName)
{
    var cookie =document.cookie;   
    cookie= cookie.split(";")  
                                          

    var x;
   for (var i=0 ; i<cookie.length ;i++)
   {
       if (cookieName.trim() == cookie[i].split("=")[0].trim())  
       {
         x= cookie[i].split("=")[1].trim();
       }

   }
   return x;
}


function getAllcookie ()
{
  var cookie = document.cookie;   
  cookie = cookie.split(";");
  var arr=[];

  for (var i =0 ; i< cookie.length ;i++)
  {
    arr[cookie[i].split("=")[0]]=cookie[i].split("=")[1]  ;  
  }    
  return arr;

}


function deleteCookie(cookieName)
{
    var expiryDate = new Date();
    expiryDate.setDate(expiryDate.getDate()-1) ;
   document.cookie=cookieName + "=" + ";expires=" + expiryDate ;

}

function hasCookie(cookieName) 
{
   if (getCookie(cookieName))
   {
    return true;
   }
   else 
   {
    return false;
   }
}