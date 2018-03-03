import {HttpClient} from "@angular/common/http";
import { Injectable } from "@angular/core";
import {BehaviorSubject} from "rxjs/BehaviorSubject";

@Injectable()
export class HomeService {

  request: HttpClient;

  constructor(req: HttpClient) {
      this.request = req;
   }

  getPokemon() {
     return this.request.get('https://pokeapi.co/api/v2/pokemon/1').toPromise();
   }
}