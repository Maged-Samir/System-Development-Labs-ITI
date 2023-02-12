

function GenerateCourse(course){
    var defCourse={
        C_Name:"ES6",
        C_Duration:"3days",
        C_Owner:"JavaScript"
    };

    var result = Object.assign({},defCourse,course)

    if(Object.keys(result).length != Object.keys(defCourse).length)
    throw new Error("Plz Cheak Your Properties");
   
    return result;
}

console.log(
  GenerateCourse({
    C_Name: "C#",
    C_Duration: "8Days",
    C_Owner: ".Net Track",
  })
);

console.log(
  GenerateCourse({
    C_Name: "C#",
  })
);

console.log(
  GenerateCourse({
    C_N: "C#",
    
  })
);