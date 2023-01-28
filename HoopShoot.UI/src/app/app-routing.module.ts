import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';
import { MatchResultsPageComponent } from './pages/match-results-page/match-results-page.component';

const routes: Routes = [
  { path: 'allTeams', component: AllTeamsPageComponent },
  { path: 'matchResults', component: MatchResultsPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
