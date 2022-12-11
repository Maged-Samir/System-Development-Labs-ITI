
var i=1;

function NextImg()
{
    i++;
    if(i>6)
    i=1;
    document.images[0].src="SlideShow/"+i+".jpg";
}

function PreImg()
{
    i--;
    if(i<1)
    i=6;
    document.images[0].src="SlideShow/"+i+".jpg";
}

var timerId;

function SlidShow()
{
    timerId=setTimeout(SlidShow,500);

   
    if(i>6)
    i=1;
    document.images[0].src="SlideShow/"+i+".jpg";
    i++;
}


function StopSlider()
{
    clearTimeout(timerId);
}