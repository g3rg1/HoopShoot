import { HttpClient } from '@angular/common/http';
import { MatchesService } from 'src/app/core/services/matches.service';
import { MatchResultsPageComponent } from './match-results-page.component';

describe('MatchResultsPageComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let service: MatchesService;
  let component: MatchResultsPageComponent;

  beforeEach(async () => {
    service = new MatchesService(httpClientSpy);
    component = new MatchResultsPageComponent(service);
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
