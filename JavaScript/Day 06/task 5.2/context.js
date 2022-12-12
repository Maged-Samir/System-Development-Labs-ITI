function display()

{

    document.addEventListener('contextmenu', function(event){

        event.preventDefault();

        alert("this option is disables");

    } );

}