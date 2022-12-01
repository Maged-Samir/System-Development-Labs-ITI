var win;
    function OpenWindow()
    {
        win=window.open("Secondpage.html","_blank","width=500 ,height=200px")
        win.focus();
    }



    function ShowMassage()
    {

    var str = 'Hello world  '.split('');

var interval = setInterval(() => {
  document.write(str[0]);
  str = str.slice(1);
  

  if (!str.length) {
    clearInterval(interval);
    window.close();
  }

}, 300);


    }

    
