function Rect(width,height)
{
    return{
        width:width,
        height:height,
        area:function(){
            return width*height;
        },
        disp:function(){
            console.log('Area is { this.area }');
        }
    }
}

var rect=new Rect(2,3);