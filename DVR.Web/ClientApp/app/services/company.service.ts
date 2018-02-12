import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class CompanyService {
  baseUrl: string = "";
  companies: Company[]
  constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
  }

  getCompanies() {
    return this.http.get(this.baseUrl + "/api/company")
      .map(response => response.json());
  }

  getTags() {
    return this.http.get(this.baseUrl + "/api/tag")
      .map(response => response.json());
  }
  
}

export interface Company {
  name: string;
  vacancies: Vacancy[];
}

export interface Vacancy {
  positionName: string;
  url: string;
  tags: string[];
}