import { Component } from '@angular/core';

//@Component is a decorator function that specifies the Angular metadata for the component.

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

//Root component defined 
export class AppComponent {
  title = 'sofani angular 5';
}
