import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LayoutComponent } from './shared/layout/layout.component';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';
import { AgGridModule } from 'ag-grid-angular';
import { MatchResultsPageComponent } from './pages/match-results-page/match-results-page.component';
import { TopOffensiveTeamsPageComponent } from './pages/top-offensive-teams-page/top-offensive-teams-page.component';
import { TopDefensiveTeamsPageComponent } from './pages/top-defensive-teams-page/top-defensive-teams-page.component';
import { HighlightMatchPageComponent } from './pages/highlight-match-page/highlight-match-page.component';
import { NotFoundPageComponent } from './pages/not-found-page/not-found-page.component';

@NgModule({
  declarations: [
    AppComponent,
    LayoutComponent,
    AllTeamsPageComponent,
    MatchResultsPageComponent,
    TopOffensiveTeamsPageComponent,
    TopDefensiveTeamsPageComponent,
    HighlightMatchPageComponent,
    NotFoundPageComponent,
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
