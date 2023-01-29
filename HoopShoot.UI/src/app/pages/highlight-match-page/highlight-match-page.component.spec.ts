import { HttpClient } from '@angular/common/http';
import { MatchesService } from 'src/app/core/services/matches.service';
import { HighlightMatchPageComponent } from './highlight-match-page.component';

describe('HighlightMatchPageComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let service: MatchesService;
  let component: HighlightMatchPageComponent;

  beforeEach(async () => {
    service = new MatchesService(httpClientSpy);
    component = new HighlightMatchPageComponent(service);
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
