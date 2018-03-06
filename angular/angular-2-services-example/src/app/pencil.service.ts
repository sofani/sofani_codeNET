import {Injectable} from '@angular/core';

import {Pencil} from './pencil';
import {LoggingService} from './logging.service';

@Injectable()
export class PencilService {
  count: number = 0;
  constructor(public loggingService:LoggingService){ }

  getPencil(){
    this.count++;
    this.loggingService.log('Getting a new pencil...');
    return new Pencil(this.count);
  }
}
