import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './shared/layout/layout.component';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';
import { AgGridModule } from 'ag-grid-angular';
import { MatchResultsPageComponent } from './pages/match-results-page/match-results-page.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    AllTeamsPageComponent,
    MatchResultsPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    AgGridModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
