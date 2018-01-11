import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { Ng2SimpleAutocomplete } from 'ng2-simple-autocomplete';
import { ChartsModule } from 'ng2-charts';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { CompanyService } from './services/company.service';
import { StatisticsService } from './services/statistics.service';
import { VacancyComponent } from './components/Vacancy/vacancy.component';
import { StatisticsComponent } from './components/statistics/statistics.component';


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        CounterComponent,
        FetchDataComponent,
        HomeComponent,
        VacancyComponent,
        StatisticsComponent,
        Ng2SimpleAutocomplete
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        ChartsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'counter', component: CounterComponent },
            { path: 'fetch-data', component: FetchDataComponent },
            { path: 'vacancies', component: VacancyComponent },
            { path: 'statistics', component: StatisticsComponent },
            { path: '**', redirectTo: 'home' }
        ]),    
    ],
    providers: [
        CompanyService,
        StatisticsService
    ]
})
export class AppModuleShared {
}
