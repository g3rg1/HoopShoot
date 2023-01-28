import { Component, OnInit } from '@angular/core';
import { ColDef, FirstDataRenderedEvent } from 'ag-grid-community';
import { Observable } from 'rxjs';
import { TeamsService } from 'src/app/core/services/teams.service';
import { MatchQuery } from 'src/app/shared/models/matchQuery.model';

@Component({
  selector: 'app-top-defensive-teams-page',
  templateUrl: './top-defensive-teams-page.component.html',
  styleUrls: ['./top-defensive-teams-page.component.css']
})
export class TopDefensiveTeamsPageComponent implements OnInit {
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
    this.rowData$ = this.teamsService.getTopDefensive();
  }

  onFirstDataRendered(params: FirstDataRenderedEvent) {
    params.api.sizeColumnsToFit();
  }
}
