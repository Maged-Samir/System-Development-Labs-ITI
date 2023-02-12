
var ReplaceLongString ={
    [Symbol.replace]:function (str,length){
        if(str.length >length)
        {
            return str.substring(0,length) + "_";
        }
        else return str;
    }
}


console.log(
'maged'.replace(ReplaceLongString,2))


console.log(
    'maged'.replace(ReplaceLongString,6))