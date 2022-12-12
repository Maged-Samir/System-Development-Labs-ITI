var dir;
var b_img;
var l_img;
var r_img;
var moving;
var freezing;
function init()
{
    document.getElementById("label3").innerText = "<img src=''icon1.gif '' style= ''left:";
    document.getElementById("label4").innerText = "<img src= ''icon2.gif '' style= ''left:";
    document.getElementById("label7").innerText = "<img src= ''TOP.JPG '' style= ''top:";

    document.getElementById("label5").innerHTML = " '' / &#62;"; 
    document.getElementById("label6").innerHTML = " '' / &#62;";
    document.getElementById("label9").innerHTML = " '' / &#62;";



    document.getElementById("label1").innerText = "10";
    document.getElementById("label2").innerText = "10";
    document.getElementById("label8").innerText = "10";

    b_img = document.getElementById(id="b_img");
    l_img = document.getElementById(id="l_img");
    r_img = document.getElementById(id="r_img");
}
function state_fun()
{
    if (document.getElementById("state").value == "go")
    {
        document.getElementById("state").value = "stop";
        moving = setInterval(move,25);
    }
    else if (document.getElementById("state").value == "stop")
    {
        document.getElementById("state").value = "go";
        freeze();
    }
}

function move()
{
    var act_loc;
    var target_loc;

    act_loc = getComputedStyle(b_img).top;
    target_loc=parseInt(act_loc);

    if (parseInt(act_loc)>9) 
    {
        dir=0;
    }
    else if (parseInt(act_loc) == -245) 
    {
        dir=1;
    }
    
    switch(dir)
    {
        case 0: 
            target_loc-=5;
            b_img.style.top=target_loc+"px";

            act_loc = getComputedStyle(l_img).left;
            target_loc=parseInt(act_loc);
            target_loc+=5;
            l_img.style.left=target_loc+"px";

            act_loc = getComputedStyle(r_img).left;
            target_loc=parseInt(act_loc);
            target_loc-=5;
            r_img.style.left=target_loc+"px";
            break;

        case 1: 
            target_loc+=5;
            b_img.style.top=target_loc+"px";

            act_loc = getComputedStyle(l_img).left;
            target_loc=parseInt(act_loc);
            target_loc-=5;
            l_img.style.left=target_loc+"px";

            act_loc = getComputedStyle(r_img).left;
            target_loc=parseInt(act_loc);
            target_loc+=5;
            r_img.style.left=target_loc+"px";
            break;
    }

    document.getElementById("label1").innerHTML = l_img.style.left.bold();
    document.getElementById("label2").innerHTML = r_img.style.left.bold();
    document.getElementById("label8").innerHTML = b_img.style.top.bold();
}

function freeze()
{
    clearInterval(moving);
    document.getElementById("label1").innerHTML = l_img.style.left.bold();
    document.getElementById("label2").innerHTML = r_img.style.left.bold();
    document.getElementById("label9").innerHTML = b_img.style.top.bold();
}

function reset_pos()
{
    l_img.style.left = 10+"px";
    r_img.style.left = 10+"px";
    b_img.style.top = 10+"px";

    document.getElementById("label1").innerHTML = l_img.style.left.bold();
    document.getElementById("label2").innerHTML = r_img.style.left.bold();
    document.getElementById("label8").innerHTML = b_img.style.top.bold();

}