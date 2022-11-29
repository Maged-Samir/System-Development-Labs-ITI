

 function count(s, c)
    {
        let res = 0;
 
        for (let i = 0; i < s.length; i++)
        {
            // checking character in string
            if (s.charAt(i) == c)
            res++;
        }
        return res;
    }
     
        let str= prompt("Enter Any Word Contains Character ");
        let c = prompt("Enter Character ");
        document.write(count(str, c));


 