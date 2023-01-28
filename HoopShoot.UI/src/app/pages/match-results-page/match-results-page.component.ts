import { Component, OnInit } from '@angular/core';
import { ColDef, FirstDataRenderedEvent } from 'ag-grid-community';
import { Observable } from 'rxjs';
import { MatchesService } from 'src/app/core/services/matches.service';
import { Match } from 'src/app/shared/models/match.model';

@Component({
  selector: 'app-match-results-page',
  templateUrl: './match-results-page.component.html',
  styleUrls: ['./match-results-page.component.css']
})
export class MatchResultsPageComponent implements OnInit {
  rowData$!: Observable<Match[]>;
  columnDefs: ColDef[] = [
    { field: 'homeTeam'},
    { field: 'awayTeam'},
    {
      headerName: 'Score',
      valueGetter: (params) => {
        return params.data.homeTeamScore + ' : ' + params.data.awayTeamScore;
      }}
  ];
  defaultColDef: ColDef = {
    sortable: true,
    filter: true,
  };

  constructor(private matchesService: MatchesService) { }

  ngOnInit(): void {
    this.rowData$ = this.matchesService.getMatches();
  }

  onFirstDataRendered(params: FirstDataRenderedEvent) {
    params.api.sizeColumnsToFit();
  }
}
