import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Team } from 'src/app/shared/models/team.model';
import { MatchQuery } from 'src/app/shared/models/matchQuery.model';

@Injectable({
  providedIn: 'root'
})
export class TeamsService {

  private apiPath: string = 'https://localhost:7167/api/teams';

  constructor(private httpClient: HttpClient) { 
  }

  getTeams(): Observable<Team[]> {
    return this.httpClient.get<Team[]>(`${this.apiPath}`);
  }

  getTopDefensive(): Observable<MatchQuery[]>{
    return this.httpClient.get<MatchQuery[]>(`${this.apiPath}/topDefensive`);
  }

  getTopOffensive(): Observable<MatchQuery[]>{
    return this.httpClient.get<MatchQuery[]>(`${this.apiPath}/topOffensive`);
  }
}
