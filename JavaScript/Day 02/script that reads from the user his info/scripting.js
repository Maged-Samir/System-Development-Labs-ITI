let choice;
while (true) {
  alert(`Choose :
      1- Red,
      2- Blue,
      3- Green.`);
  choice = parseInt(prompt("Enter Code of Color:"));
  if (isNaN(choice) || choice < 1 || choice > 3) {
    alert("Choose Corect Number.");
    continue;
  }
  break;
}
let color;
switch (choice) {
  case 1:
    color = "red";
    break;
  case 2:
    color = "blue";
    break;
  case 3:
    color = "green";
    break;
}

while (true) {
  let userName = prompt("Enter Your Name:");
  if (isNaN(userName)) {
    document.write(
      `<p><span style="color: ${color};">Name :</span> ${userName}</p>`
    );
  } else {
    alert("Enter Name Not Numbers.");
    continue;
  }
  break;
}
while (true) {
  //استخدمت parseInt() علشان لو غلط ودخل حروف وسط الكلام يلغيها ويقارن ب 8
  let phoneNumber = prompt("Enter Your Phone Number:");
  if (parseInt(phoneNumber).toString().length === 8) {
    document.write(
      `<p><span style="color: ${color};">Phone Number :</span> ${parseInt(
        phoneNumber
      )}</p>`
    );
  } else {
    alert("Enter Phone Number Wthis 8 Numbers With No Character.");
    continue;
  }
  break;
}
while (true) {
  let mobileNumber = prompt("Enter Your Mobile Number:");
  if (
    //شلت .string()&parseInt() علشان بيششل الصفر الي في اول الرقم
    mobileNumber.length === 11 &&
    mobileNumber.search(/010|011|012/) !== -1
  ) {
    document.write(
      `<p><span style = "color: ${color};">Mobile Number :</span> 0${parseInt(
        mobileNumber
      )}</p>`
    );
  } else {
    alert(
      "Enter Mobile Number Wthis 11 Numbers With No Character And Starts With (010|011|012)."
    );
    continue;
  }
  break;
}
while (true) {
  let email = prompt("Enter Your Email:");
  if (email.search(/@/) !== -1 && email.search(/.com/) !== -1) {
    document.write(
      `<p><span style = "color: ${color};">Email :</span> ${email}</p>`
    );
  } else {
    alert("You Should Enter Avalid Email");
    continue;
  }
  break;
}
let today = new Date();
document.write(
  `<p><span style="color: ${color};">Welcome :</span> ${today.toLocaleDateString()}</p>`
);
