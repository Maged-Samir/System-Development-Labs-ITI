var obj={
    Id:1,
    Name:"Maged",
    Age:70,

    Fun: function*(){
        var keys =Object.keys(this);

        for(const key of keys)
        {
            if(key != "Fun")
            yield [key,this[key]];
        }
    }
}

for(const i of obj.Fun()){
    console.log(i);
}