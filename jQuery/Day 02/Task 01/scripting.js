(function () { 
    $("img").click(function() {
        $( "img" ).animate(
        {
          left: "1200"
        },
        {
            duration: 3000,
            step: function( currentLeft ){
                $('#left').text(currentLeft.toFixed());
            }
        }, 
        "easeInOutCubic");
      });
 }());
