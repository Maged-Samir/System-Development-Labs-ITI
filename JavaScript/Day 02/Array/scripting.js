


var arr = [];

for (var i=1;arr.length<3;i++)
{
    var number = parseInt(prompt(`enter numbers ${i}:`));
    if (!isNaN(number)) {
     arr.push(number);
   } 
   else 
   {
      alert("You Must Enter Numbers.");
      continue;
    }
}




 var sum = 0;
 var divid = 1;
 var muliply = 1;
 for (var i = 0; i < arr.length; i++) {
   sum += arr[i];
   muliply *= arr[i];
  divid = arr[i] / divid;
 }
 document.write(
    `<p><span style="color: red;">Sum Of 3 Values =</span> ${sum}</p>`
 );
document.write(
   `<p><span style="color: red;">Multiplication Of 3 Values =</span> ${muliply}</p>`
 );
 document.write(
  `<p><span style="color: red;">Division Of 3 Values =</span> ${divid}</p>`
 );





 





var arr = [];

for (var i=1;arr.length<5;i++)
{
    var number = parseInt(prompt(`enter numbers ${i}:`));
    if (!isNaN(number)) {
     arr.push(number);
   } 
   else 
   {
      alert("You Must Enter Numbers.");
      continue;
    }
}
document.write(
  `<span style="color: red;">  You Have Entered The Values Of =</span> ${arr.join(
    ", "
  )}`
);
var ascending = arr.sort(function (a, b) {
  return a - b;
});
document.write(
  `<p><span style="color: red;"> Ascending Values =</span> ${ascending.join(
    ", "
  )}`
);
var dascending = ascending.reverse();
document.write(
  `<p><span style="color: red;"> Dascending Values =</span> ${dascending.join(
    ", "
  )}`
);