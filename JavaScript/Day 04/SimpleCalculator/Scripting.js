
//Display 
function EnterNumber(val){

    document.getElementById('result').value += val

    return val

}

function EnterEqual(){

    let x = document.getElementById('result').value

    let y = eval(x);
    
    document.getElementById('result').value = y

    return y

}

function EnterClear(){

    document.getElementById('result').value = ''

}