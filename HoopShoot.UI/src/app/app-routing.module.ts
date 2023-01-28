import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';
import { MatchResultsPageComponent } from './pages/match-results-page/match-results-page.component';
import { TopDefensiveTeamsPageComponent } from './pages/top-defensive-teams-page/top-defensive-teams-page.component';
import { TopOffensiveTeamsPageComponent } from './pages/top-offensive-teams-page/top-offensive-teams-page.component';

const routes: Routes = [
  { path: 'allTeams', component: AllTeamsPageComponent },
  { path: 'matchResults', component: MatchResultsPageComponent },
  { path: 'topOffensive', component: TopOffensiveTeamsPageComponent },
  { path: 'topDefensive', component: TopDefensiveTeamsPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
