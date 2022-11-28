
var sum=0;
function fun(){
do
{
var x =parseInt( prompt ("Enter Number","jj"));
if(isNaN(x))
{
    document.write("You Entered Wrong Values PLZ Refresh your page and enter numeric Values");
break;
}
sum+=x;
}while(sum<100 && x!=0);
document.writeln(sum);

}

fun();


