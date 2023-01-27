import { Component } from '@angular/core';
import { MatchesService } from './core/services/matches.service';
import { TeamsService } from './core/services/teams.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private matchesService: MatchesService, private teamsService: TeamsService) {
  }

  title = 'HoopShoot.UI';
  
}
