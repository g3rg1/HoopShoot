import { Component, OnInit, ViewChild } from '@angular/core';
import { AgGridAngular } from 'ag-grid-angular';
import { ColDef, FirstDataRenderedEvent, GridApi } from 'ag-grid-community';
import { Observable, Subject, takeUntil } from 'rxjs';
import { TeamsService } from 'src/app/core/services/teams.service';
import { Team } from 'src/app/shared/models/team.model';

@Component({
  selector: 'app-all-teams-page',
  templateUrl: './all-teams-page.component.html',
  styleUrls: ['./all-teams-page.component.css']
})
export class AllTeamsPageComponent implements OnInit {
    notifier = new Subject<void>;
    teams!: Team[];
    rowData$!: Observable<Team[]>;
    columnDefs: ColDef[] = [
      { field: 'name' }
    ];
    defaultColDef: ColDef = {
      sortable: true,
      filter: true,
    };

    @ViewChild(AgGridAngular) agGrid!: AgGridAngular;
  
    constructor(private teamsService: TeamsService) { }

    ngOnInit(): void {
      this.rowData$ = this.teamsService.getTeams();
    }

    onFirstDataRendered(params: FirstDataRenderedEvent) {
      params.api.sizeColumnsToFit();
    }
}
