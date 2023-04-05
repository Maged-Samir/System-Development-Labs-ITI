import { Component, EventEmitter, Output } from '@angular/core';


@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  name=" ";
  age=0;

  students:{name:string;age:number;}[]=[];
  @Output() sendEvent =new EventEmitter();

  SendData()
  {
    let student={name:this.name,age:this.age};
    this.students.push(student)
    this.sendEvent.emit(this.students);
    // console.log(this.students);
  }
  
}
