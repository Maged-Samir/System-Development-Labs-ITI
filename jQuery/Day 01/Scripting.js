$(function(){
      $("#divAbout,#divGalary,#divComplain,#testMenu,#divResult").hide();

      $("#inAbout").click(function(){
        $("#divGalary,#testMenu,#divComplain,#divResult").hide(),
        $("#divAbout").show("fast");
      })

      $("#inGalary").click(function(){
        $("#divAbout,#testMenu,#divComplain,#divResult").hide(),
        $("#divGalary").show("fast");
      })

      $("#inServices").click(function(){
        $("#divAbout,#divGalary,#divComplain,#divResult").hide(),
        $("#testMenu").slideDown("normal");
      })

      $("#inComplain").click(function(){
        $("#divAbout,#divGalary,#testMenu,#divResult").hide(),
        $("#divComplain").show("fast");
      })

    
      $("#btnChange").click(function(){
        $("#divAbout,#divGalary,#testMenu,#divComplain").hide(),
        $("#divResult").show("fast");
        var inputString1 = $("#iname").val();
        var inputString2 = $("#iphone").val();
        $("#lbOne").text(inputString1);
        $("#lbTwo").text(inputString2);
      })

      $("#btnChange2").click(function(){
        $("#divAbout,#divGalary,#testMenu,#divResult").hide(),
        $("#divComplain").show("fast");
      })
      

})



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