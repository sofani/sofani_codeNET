import {Component} from '@angular/core';

import {Pencil} from './pencil';
import {PencilService} from './pencil.service';

@Component({
  selector: 'person',
  template: '<p>Person: {{name}}: {{pencil.id}}</p>'
})
export class PersonComponent {
  name: string;
  pencil: Pencil;

  constructor(pencilService: PencilService){
    this.name = 'Hello';
    this.pencil = pencilService.getPencil();
  }
}
