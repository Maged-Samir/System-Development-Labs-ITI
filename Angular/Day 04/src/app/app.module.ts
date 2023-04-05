import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';


import { AppComponent } from './app.component';
import { HeaderComponent } from './Components/header/header.component';
import { AboutComponent } from './Components/about/about.component';
import { ErrorComponent } from './Components/error/error.component';
import { UsersComponent } from './Components/users/users.component';
import { UsersDetilesComponent } from './Components/users-detiles/users-detiles.component';
import { HomeComponent } from './Components/home/home.component';

let routes:Routes =[
  {path:"",component:UsersComponent},
  {path:"users",component:UsersComponent},
  {path:"users/:id",component:UsersDetilesComponent},
  {path:"about",component:AboutComponent},
  {path:"**",component:ErrorComponent}
  
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    AboutComponent,
    ErrorComponent,
    UsersComponent,
    UsersDetilesComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
