var Person = {

}

var handler = {

  set(target,prop,value)
  {
    switch(prop)
    {
      case "name" : 
      if( value.length == 7  && value.match("^[a-zA-Z]+$"))
        target[prop] = value; 
      else
        console.log("PLz Enter Valid Name");
      break;

      case "address":

      if( value.match("^[a-zA-Z]+$"))
        target[prop] =value;
        else
        console.log("PLz Enter Valid Address");
      break;

      case "age" :
      if( value.match("^[0-9]+$") && parseInt(value) > 25 && parseInt(value) < 60 )
      target[prop] =value;
      else
      console.log("PLz Enter Valid Age");

      break;


    }

  },
  get(target,prop)
  {
    if( target.hasOwnProperty(prop))  
      return target[prop]; 
      else
      console.log(`Plz Cheak Your Properity`);
      return 0; 

  }

}

var myProxy = new Proxy(Person,handler)


