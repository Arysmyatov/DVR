import { Component } from '@angular/core';
import { Http } from '@angular/http';
import { Company, CompanyService } from '../../services/company.service';
import { AutoCompleteItem } from 'ng2-simple-autocomplete';

@Component({
    selector: 'vacancies',
    templateUrl: './vacancy.component.html',
    styleUrls: ["./vacancy.component.css"]
})
export class VacancyComponent {
    public companies: Company[];
    selectedTag: AutoCompleteItem;
    allCompanies: Company[];
    staticData: AutoCompleteItem[] = [];

    constructor(private CompanyService: CompanyService) {
        CompanyService.getCompanies()
            .subscribe(result => {
                this.allCompanies = result;
                this.companies = result
            });
        CompanyService.getTags()
            .subscribe(result => this.staticData = result);
    }

    isTagSelected(t: string){
        return  this.selectedTag && this.selectedTag.value == t;
    }

    onSelectItem(item: AutoCompleteItem) {
        this.selectedTag = item;
        this.companies = this.allCompanies.filter(compny => {
            let vacancies = compny.vacancies.filter(v => {
                let tags = v.tags.filter(t => t === item.value);
                return tags.length > 0;
            });
            return vacancies.length > 0;
        })
    }

    onReset() {
        this.companies = this.allCompanies;
    }



}