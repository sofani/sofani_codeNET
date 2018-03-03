import { Component, OnInit } from "@angular/core";


@Component({
    selector: 'home',
    templateUrl: 'home.component.html',
    styleUrls: ['home.component.css'],
})
export class HomeComponent implements OnInit {
    //INTERPOLATION
     itemCount: Number;
     //PROPERTY BINDING
     btnText: string = "Add An Item";
     //Two way binding
     goalText: string = "my first life cycle";
     //Event Binding

     goals = [];
    constructor() {

    }
    //it is a life cycle hook which is initiated when app loads or the component itself loads
    ngOnInit() {
       this.itemCount = this.goals.length;
    }

    AddItem() {
        this.goals.push(this.goalText);
        this.goalText = " ";
        this.itemCount = this.goals.length;
    }
}