import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { HeaderSectionComponent } from './header-section/header-section.component';
import { LoginComponent } from './login/login.component';
import { SharedLayoutComponent } from './Shared/shared-layout/shared-layout.component';
import { TicketComponent } from './ticket/ticket.component';

const routes: Routes =
    [
        {
            path: '', component: SharedLayoutComponent,
            children: [
                //Todas las páginas que necesiten del layout base van aquí
                { path: '', component: HomeComponent },
                { path: 'ticket', component: TicketComponent,pathMatch: 'full' }
            ]
        },
        //Todas las páginas que no requieran un layout van aquí
        { path: 'Login', component: LoginComponent }
    ];


@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        HeaderSectionComponent,
        LoginComponent,
        SharedLayoutComponent,
        TicketComponent
    ],
    imports: [
        BrowserModule,
        RouterModule.forRoot(routes),
        HttpClientModule,
        FormsModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
