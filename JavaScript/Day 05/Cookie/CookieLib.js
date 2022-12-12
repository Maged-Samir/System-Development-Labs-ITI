

 function createCookie(cookieName,cookieValue,isExpired)
{
    if(isExpired)
    {
        document.cookie = cookieName + "=" + cookieValue;
    }
    else
    {
        var date = new Date();
        date.setMonth(date.getMonth()+1)
        document.cookie= cookieName+"="+cookieValue+"; expires ="+date.toUTCString();
    }
}

 function disPlayCookies()
{
    var cookies = getCookies()
    for(var cookie of cookies)
    {
        console.log(cookie)
    }
}


 function getCookies()
{
    return document.cookie.split(";");
}


 function deleteCookie(name)
{
    if(hasCookie(name))
    {
        var date = new Date();
        date.setMonth(date.getMonth()-1)
        document.cookie= name+"="+"; expires ="+date.toUTCString();
    }
}



 function hasCookie (cookieName)
{
    var cookies = getCookies();
    for(var cookie of cookies)
    {
        if(cookie.split("=")[0]===cookieName) return true;
    }
    return false;
}


 function getCookie(cookieName)
{
    var cookies = getCookies();
    for(var cookie of cookies)
    {
        if(cookie.split("=")[0]===cookieName) return cookie.split("=")[1];
    }
    return "Not found"
}


 
