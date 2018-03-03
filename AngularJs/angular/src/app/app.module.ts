import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
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
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    
 
  ],
  imports: [
    //BrowserModule an application that runs on a browser we need BrowserModule
    BrowserModule, PapiModule, HomeModule, AboutModule, FormsModule, AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent, PapiComponent, HomeComponent, AboutComponent]
})
export class AppModule { }
