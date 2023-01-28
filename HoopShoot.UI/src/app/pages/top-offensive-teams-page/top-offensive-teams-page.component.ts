import { Component, OnInit } from '@angular/core';
import { ColDef, FirstDataRenderedEvent } from 'ag-grid-community';
import { Observable } from 'rxjs';
import { TeamsService } from 'src/app/core/services/teams.service';
import { MatchQuery } from 'src/app/shared/models/matchQuery.model';

@Component({
  selector: 'app-top-offensive-teams-page',
  templateUrl: './top-offensive-teams-page.component.html',
  styleUrls: ['./top-offensive-teams-page.component.css']
})
export class TopOffensiveTeamsPageComponent implements OnInit {
  rowData$!: Observable<MatchQuery[]>;
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

  constructor(private teamsService: TeamsService) { }

  ngOnInit(): void {
    this.rowData$ = this.teamsService.getTopOffensive();
  }

  onFirstDataRendered(params: FirstDataRenderedEvent) {
    params.api.sizeColumnsToFit();
  }
}
