import { Component } from '@angular/core';

//@Component is a decorator function that specifies the Angular metadata for the component.
//Root Component of the application
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//Root component defined 
export class AppComponent {
  title: string;
  name: string;
  names: string[];
  age: number;
  imageSrc: string;
  clicking: string;
  show="true";
  constructor() {
    this.title = 'Angular 5'
    this.name = 'sofani';
    this.age = 30;
    this.imageSrc = '/favicon.ico';
    this.names = ['sofani', 'paul', 'tul' ];
   
  }
  hello() {
    this.clicking = "Hi Mr Event";
  }
  showoutput(val: string) {
    console.log("value: " + val)
  }
}
