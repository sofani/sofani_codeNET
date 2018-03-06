import { Component } from '@angular/core';

import {PencilService} from './pencil.service';
@Component({
  selector: 'my-app',
  providers: [PencilService],
  template: `<h1>Hello {{name}}</h1><person></person>`,
})
export class AppComponent  { name = 'Angular'; }
