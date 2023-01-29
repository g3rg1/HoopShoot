import { HttpClient } from '@angular/common/http';
import { TeamsService } from 'src/app/core/services/teams.service';
import { TopDefensiveTeamsPageComponent } from './top-defensive-teams-page.component';

describe('TopDefensiveTeamsPageComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let service: TeamsService;
  let component: TopDefensiveTeamsPageComponent;

  beforeEach(async () => {
    service = new TeamsService(httpClientSpy);
    component = new TopDefensiveTeamsPageComponent(service);
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
