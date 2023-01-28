import { Component, OnInit } from '@angular/core';
import { TeamsService } from 'src/app/core/services/teams.service';
import { MatchesService } from 'src/app/core/services/matches.service';
import { Subject, takeUntil } from 'rxjs';
import { Match } from '../../models/match.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-layout',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.css']
})
export class LayoutComponent implements OnInit {
  
  notifier = new Subject<void>;

  matches!: Match[];
  highlightMatch!: Match;
  
  constructor(private teamsService: TeamsService, private matchesService: MatchesService, public readonly router: Router) { }

  ngOnInit(): void {
     this.matchesService.getMatches()
     .pipe(takeUntil(this.notifier))
     .subscribe(matches => this.matches = matches);

     this.matchesService.getHighLightMatch()
     .pipe(takeUntil(this.notifier))
     .subscribe(match => this.highlightMatch = match);
  }

}
