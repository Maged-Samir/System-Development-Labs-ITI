function confirmMessage()
{
    var confirmSubmit = confirm("Do you really want to submit?");  
    {
        open("welcomeWin.html" , "" , "width = 200 , height = 200");  
    }
    
}

function za3bola(){
    
    var newEvent = new Event("Time");
    
    document.getElementById("sub").addEventListener("Time" , function(){
        var name = document.getElementById("username");
        var age = document.getElementById("userage");
        if((name.value == "") && (age.value == ""))
        {
            alert("plz enter your data");
        }
    });
    
    setTimeout(function(){
        document.getElementById("sub").dispatchEvent(newEvent);
    },7000);
}