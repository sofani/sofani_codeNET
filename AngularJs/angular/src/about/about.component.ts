import { Component } from "@angular/core";
import { PapiService } from "../papi/papi.service";


@Component({
    selector: 'about',
    templateUrl: 'about.component.html',
    styleUrls:['about.component.css'],
    providers:[PapiService]
})

export class AboutComponent {
      name: string;
      age: number;
      favoriteBooks: string[];
      phone: {cell: string, home: string };
      constructor(papiService: PapiService) {
          this.name = "Tiffany";
          this.age = 37;
          this.favoriteBooks = ['java', 'c', 'javascript'];
          this.phone = {
            cell: '0544596984',
            home: '114173'
        }
      }
      
}
