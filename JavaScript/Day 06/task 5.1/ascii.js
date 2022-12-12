
function detectCode()
{
    document.addEventListener("keydown" , function(event){

        let unicode= event.keyCode;

        if(event.altKey)

        {

            alert("The ALT key was pressed! and it's ASCII Code is " + unicode);

        }

        else if(event.ctrlKey)

        {

            alert("The CTRL key was pressed! and it's ASCII Code is " + unicode);

        }

        else if(event.shiftKey)

        {

            alert("The Shift key was pressed! and it's ASCII Code is " + unicode);

        }

        else

        {

            alert("The ASCII Code pressed is " + unicode);

        }

    } , fate);
}