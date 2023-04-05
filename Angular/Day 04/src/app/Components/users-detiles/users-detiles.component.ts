import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-users-detiles',
  templateUrl: './users-detiles.component.html',
  styleUrls: ['./users-detiles.component.css']
})
export class UsersDetilesComponent {

  id:number;
  
    constructor(myActivated:ActivatedRoute) { 
    console.log(myActivated.snapshot.params["id"]);
    this.id=myActivated.snapshot.params["id"];
  }

  
}
