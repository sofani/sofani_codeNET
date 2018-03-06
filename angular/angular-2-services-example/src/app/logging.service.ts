import {Injectable} from '@angular/core';

@Injectable()
export class LoggingService{
  log(msg: string){
    let today = new Date();
    let date = `${today.getMonth()+1}-${today.getDate()}-${today.getFullYear()}`;
    let datetime = `${date} ${today.getHours()}:${today.getMinutes()}:${today.getSeconds()}`;
    console.log(`${datetime}---${msg}`);
  }
}
