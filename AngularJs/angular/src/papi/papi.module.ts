import {NgModule} from "@angular/core";
import {PapiComponent} from "./papi.component";
import {PapiService} from "./papi.service";
import { HttpClientModule } from "@angular/common/http";
//is a decorator that takes metadata object that tell angular how to compile and launch the application.
@NgModule ({
    declarations:[
        PapiComponent
    ],
    imports: [HttpClientModule],
    providers: [PapiService],
    bootstrap: []
})
export class PapiModule{}