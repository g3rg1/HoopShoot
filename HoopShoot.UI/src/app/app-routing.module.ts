import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';
import { HighlightMatchPageComponent } from './pages/highlight-match-page/highlight-match-page.component';
import { MatchResultsPageComponent } from './pages/match-results-page/match-results-page.component';
import { NotFoundPageComponent } from './pages/not-found-page/not-found-page.component';
import { TopDefensiveTeamsPageComponent } from './pages/top-defensive-teams-page/top-defensive-teams-page.component';
import { TopOffensiveTeamsPageComponent } from './pages/top-offensive-teams-page/top-offensive-teams-page.component';

const routes: Routes = [
  {path: '', redirectTo: '/allTeams', pathMatch: 'full'},
  { path: 'allTeams', component: AllTeamsPageComponent },
  { path: 'matchResults', component: MatchResultsPageComponent },
  { path: 'topOffensive', component: TopOffensiveTeamsPageComponent },
  { path: 'topDefensive', component: TopDefensiveTeamsPageComponent },
  { path: 'highlight', component: HighlightMatchPageComponent },
  { path: 'notFound', component: NotFoundPageComponent },
  { path: '**', redirectTo: 'notFound' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
