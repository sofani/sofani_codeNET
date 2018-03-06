import { BrowserModule } from '@angular/platform-browser'; //for running the application in the browser
import { NgModule } from '@angular/core'; //as a decorator for three properties that we specifie(declaration, bootstrap, imports)
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { HomeComponent } from '../home/home.component';
import {PapiComponent} from '../papi/papi.component';
import { PapiModule } from '../papi/papi.module';

import { HomeModule } from '../home/home.module';
import { AboutModule } from '../about/about.module';
import { AboutComponent } from '../about/about.component';
import { AppRoutingModule } from './/app-routing.module';
//Decorator >Is a tag that supplies metadata about the underlying components.
//          >A function that adds metadata to a class, its members (properties and functions ) and function arguments.
//is a decorator that takes metadata object which is used to tell angular how to compile and launch the application.
//Root module of the component
@NgModule({
  declarations: [ // specifies components, decleratives, and pipes
    AppComponent,
    HomeComponent,
    AboutComponent
 
  ],
  imports: [ // only for ngModule classes // specifies all required modules
    //BrowserModule an application that runs on a browser we need BrowserModule
    BrowserModule, PapiModule, HomeModule, AboutModule, FormsModule, AppRoutingModule
  ],
  providers: [], //specifies all required services
  bootstrap: [AppComponent, PapiComponent, HomeComponent, AboutComponent] //specifies only the root Component
})
export class AppModule { }
