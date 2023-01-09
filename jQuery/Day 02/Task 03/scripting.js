$("#rabbit").draggable();

$("#hole").droppable(
    {
        accept: "#rabbit",
        drop:  function () {
            $("#rabbit").toggle("explode");
        }
    });