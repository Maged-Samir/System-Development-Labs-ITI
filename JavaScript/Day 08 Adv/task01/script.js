var obj={
    id:1,
    name:'Ahmed',
    age:30,
    address:'Cairo',
    Getter_Setter: function(){
        for(var i in this)
        {
            if(typeof(this[i] !='function'))
            {
                this["set"+i]=
                (function(prop)
                    {
                        return function(param){
                            this[prop]=param;
                        };
                    }
                )(i)   
            }
            this["get"+i]=
            (function (prop){
                return function(){
                    return this[prop];
                }
            })(i)
        }
    }
}