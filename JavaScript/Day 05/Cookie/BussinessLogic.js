/*
function createCookie(cookieName,cookieValue,isExpired)
{
    if(isExpired)
    {
        document.cookie =cookieName+"="+cookieValue;
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
    return document.cookie.split("; ");
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


function hasCookie (cookieName){
    var cookies = getCookies();
    for(var cookie of cookies){
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
*/


function onClickOnSubmit()
{ 
    createCookie("userName",document.getElementById("userNameFiled").value,false)
    createCookie("userAge",document.getElementById("userAgeFiled").value,false)
    createCookie("userGender",document.querySelector('input[name="gender"]:checked').value,false)
    var selected = document.getElementById("color")
    createCookie("userFavColor",selected.options[selected.selectedIndex].text,false)
    createCookie("numberOfVisite",0,true)
    window.location.assign("./display.html")
}


function getData()
{
    
    var image = getCookie("userGender");
    var name =getCookie("userName");
    var color = getCookie("userFavColor")
    if(image == 1)
    {
        document.writeln(`<img src = "./images/male.jpg"/>`)
    }
    else
    {
        document.writeln(`<img src = "./images/female.jpg"/>`)
    }

    document.write(`welcome <span style="color:${color}">${name}</span>`)
    if(hasCookie("numberOfVisite"))
    {
        var value = parseInt(getCookie("numberOfVisite"));
        createCookie("numberOfVisite", value+1 ,true)
        document.write(`  you visted this site<span style="color:${color}">${value + 1} </span>`)
    }
    else
    {
        createCookie("numberOfVisite", 1 ,true)
        document.write(`   you visted this site <span style="color:${color}">${1}</span>`)
    }
}

//getData();