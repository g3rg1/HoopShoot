import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Match } from 'src/app/shared/models/match.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MatchesService {

  private apiPath: string = 'https://localhost:7167/api/matches';

  constructor(private httpClient: HttpClient) { }

  getMatches(): Observable<Match[]> {
    return this.httpClient.get<Match[]>(`${this.apiPath}`);
  }

  getHighLightMatch(): Observable<Match> {
    return this.httpClient.get<Match>(`${this.apiPath}/highlight`);
  }
}
