import { Component, OnInit } from '@angular/core';
import { ColDef, FirstDataRenderedEvent } from 'ag-grid-community';
import { Observable} from 'rxjs';
import { TeamsService } from 'src/app/core/services/teams.service';
import { Team } from 'src/app/shared/models/team.model';

@Component({
  selector: 'app-all-teams-page',
  templateUrl: './all-teams-page.component.html',
  styleUrls: ['./all-teams-page.component.css']
})
export class AllTeamsPageComponent implements OnInit {
    rowData$!: Observable<Team[]>;
    columnDefs: ColDef[] = [
      { field: 'name' }
    ];
    defaultColDef: ColDef = {
      sortable: true,
      filter: true,
    };

    constructor(private teamsService: TeamsService) { }

    ngOnInit(): void {
      this.rowData$ = this.teamsService.getTeams();
    }

    onFirstDataRendered(params: FirstDataRenderedEvent) {
      params.api.sizeColumnsToFit();
    }
}
