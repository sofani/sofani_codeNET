import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import {PersonComponent} from './person.component';
import {LoggingService} from './logging.service';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent, PersonComponent ],
  providers: [LoggingService],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
