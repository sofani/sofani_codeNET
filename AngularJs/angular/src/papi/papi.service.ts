import { Injectable } from '@angular/core';

import {HttpClient} from "@angular/common/http";

@Injectable()
export class PapiService {
  count : 0;
  request: HttpClient;

  constructor(req: HttpClient) {
      this.request = req;
   }

  getPokemon() {
     return this.request.get('https://pokeapi.co/api/v2/pokemon/1').toPromise();
   }

   getPencil() {
     this.count++;
     //return new this.Pencil(this.count);
   }
}
