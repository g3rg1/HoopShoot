import { Component, OnInit } from '@angular/core';
import { Subject, takeUntil } from 'rxjs';
import { MatchesService } from 'src/app/core/services/matches.service';
import { Match } from 'src/app/shared/models/match.model';

@Component({
  selector: 'app-highlight-match-page',
  templateUrl: './highlight-match-page.component.html',
  styleUrls: ['./highlight-match-page.component.css']
})
export class HighlightMatchPageComponent implements OnInit {
  notifier = new Subject<void>;
  highlightMatch!: Match;
  constructor(private matchesService: MatchesService) { }

  ngOnInit(): void {
    this.matchesService.getHighLightMatch()
    .pipe(takeUntil(this.notifier))
    .subscribe(match => {
      this.highlightMatch = match;
    });
  }
}
