import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent {

  myRegistrationValidation=new FormGroup({
    name:new FormControl("Enter Your Name",[Validators.required,Validators.minLength(3)]),
    age:new FormControl("",[Validators.min(18),Validators.max(30)])
  })

  Submitting()
  {
    // console.log(this.myRegistrationValidation.controls["name"].value,this.myRegistrationValidation.controls["name"].valid);
    // console.log(this.myRegistrationValidation.controls["age"].value,this.myRegistrationValidation.controls["age"].valid);

    if (this.myRegistrationValidation.valid) {
      alert('Form submitted successfully!');

    }

  }

  get NameValid()
  {
    return this.myRegistrationValidation.controls["name"].valid
  }

  get AgeValid()
  {
    return this.myRegistrationValidation.controls["age"].valid
  }

  
}
