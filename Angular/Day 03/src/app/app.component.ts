import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'SlideShow';

  students:{name:string;age:number}[]=[]

  resiveData(data:any)
  {
    this.students.push(data)
    // console.log(data)
    this.students=data;
  }

  
}
