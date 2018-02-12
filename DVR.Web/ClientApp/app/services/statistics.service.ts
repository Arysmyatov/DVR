import { Injectable, Inject } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

@Injectable()
export class StatisticsService {
    baseUrl: string = "";
    constructor(private http: Http, @Inject('BASE_URL') baseUrl: string) {
    }

    getData() {
        return this.http.get(this.baseUrl + "/api/statistic")
            .map(response => {
                let statisticsData: StatisticsSourceData[];
                statisticsData = response.json();
                return statisticsData.map(item => new ChartGroup(item))
            });
    }
}


export class ChartGroup {
    GroupName: string;
    lineChartLabels: Array<any>;   
    Data: ChartData[];

    constructor(item: StatisticsSourceData) {
        this.GroupName = item.name;
        if(item.tagResults && item.tagResults.length > 0) {
            this.lineChartLabels = item.tagResults[0].results.map(r => r.date.toLocaleString());
            this.Data = item.tagResults.map(tr => new ChartData(tr))                
        }

    }

}

export class ChartData {
    data: number[];
    label: string;

    constructor(item: TagResult) {
        this.label = item.name;
        this.data  = item.results.map(sr => sr.count);
    }
}

export class ChartSeria {
    Name: string;
    Value: number;

    constructor(item: SourceResult) {
        let newDate = new Date(item.date);
        this.Name = newDate.toLocaleDateString();
        this.Value = item.count;
    }
}

export class StatisticsSourceData {
    name: string;
    tagResults: TagResult[];
}

export class TagResult {
    name: string;
    results: SourceResult[];
}

export class SourceResult {
    date: Date;
    count: number;
}