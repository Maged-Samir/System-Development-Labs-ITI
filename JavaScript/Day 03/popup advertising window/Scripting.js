

    function OpenWindow()
    {
        var win=window.open("Secondpage.html","_blank","width=500 ,height=200px")
        win.focus();
    }



    function ShowMassage()
    {

    var str = 'Hello world'.split('');

var interval = setInterval(() => {
  document.write(str[0]);
  str = str.slice(1);
  
  if (!str.length) {
    clearInterval(interval);
  }
}, 500);

    }


    function pageScroll() {
    	window.scrollBy(0,50); // horizontal and vertical scroll increments
    	scrolldelay = setTimeout('pageScroll()',100); // scrolls every 100 milliseconds
       }




