import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AllTeamsPageComponent } from './pages/all-teams-page/all-teams-page.component';

const routes: Routes = [
  { path: 'allTeams', component: AllTeamsPageComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
