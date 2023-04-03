import { Component } from '@angular/core';

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.css']
})
export class SecondComponent {
  
  imgsrc = '/assets/Images/1.jpg';
  i = 1;
  interval: any = undefined;


  NextImg() {
    this.i++;
    if (this.i > 6)
      this.i = 6;
    this.imgsrc = "/assets/Images/" + this.i + ".jpg";
  }

  PreImg() {
    this.i--;
    if (this.i < 1)
      this.i = 1;
    this.imgsrc = "/assets/Images/" + this.i + ".jpg";
  }

  timerId: any;

  SlidShow()
  {
      this.timerId=setInterval(()=>{
        this.i++
        this.imgsrc="/assets/Images/"+this.i+".jpg"

        if(this.i>6)(this.i=1)
        this.imgsrc="/assets/Images/"+this.i+".jpg";


      },1000)
  }

  StopSlider()
{
    clearTimeout(this.timerId);
}


}
