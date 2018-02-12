import { Component, ElementRef } from '@angular/core';

@Component({
    selector: 'multiselect',
    templateUrl: './multiselect.component.html',
    styleUrls: ['./multiselect.component.css']
})
export class MultiselectComponent {
    public countries = ["Albania", "Andorra", "Armenia", "Austria", "Azerbaijan", "Belarus",
        "Belgium", "Bosnia & Herzegovina", "Bulgaria", "Croatia", "Cyprus",
        "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Georgia",
        "Germany", "Greece", "Hungary", "Iceland", "Ireland", "Italy", "Kosovo",
        "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Malta",
        "Moldova", "Monaco", "Montenegro", "Netherlands", "Norway", "Poland",
        "Portugal", "Romania", "Russia", "San Marino", "Serbia", "Slovakia", "Slovenia",
        "Spain", "Sweden", "Switzerland", "Turkey", "Ukraine", "United Kingdom", "Vatican City"];

    public filteredList = [];
    public elementRef: ElementRef;
    public query: string;

    constructor(myElement: ElementRef) {
        this.elementRef = myElement;
    }

    filter() {
        if (this.query !== "") {
            this.filteredList = this.countries.filter(function (el: any) {
                return true;
            }.bind(this));
        } else {
            this.filteredList = [];
        }
    }

    select(item: string) {
        this.query = item;
        this.filteredList = [];
    }
}