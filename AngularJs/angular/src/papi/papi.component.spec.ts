import { PapiComponent } from "./papi.component";
import { TestBed, async } from "@angular/core/testing";
import { PapiService } from "./papi.service";
import { HttpClientModule } from "@angular/common/http";

describe('papi should do', () => {
    describe('hello', async () => {
        beforeEach(() => {
            TestBed.configureTestingModule({
                declarations: [
                    PapiComponent
                ],
                imports: [HttpClientModule],
                providers: [PapiService]
            }).compileComponents();
        });
      
        it ('should say hello', () => {
            var sub: PapiComponent = TestBed.createComponent(PapiComponent).debugElement.componentInstance;
            expect(sub.hello).toEqual('Pokemon API');
        });

        it('should say pokemon', async((done) =>{
          
            var sub1: PapiComponent = TestBed.createComponent(PapiComponent).componentInstance;
            var sub2: PapiService = sub1.service;
            var r;
            //task waiting for
            var p = new Promise(() => {
                r = sub2.getPokemon();
                sub1.showPoke2(r);
            });
          

            p.then(() => {
                expect(sub1.poke.name).not.toBeNull();
                expect(sub1.poke.name).toBe('Bulbasaur');
            });
          
        }));
    })
})