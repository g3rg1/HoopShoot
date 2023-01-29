import { HttpClient } from '@angular/common/http';
import { TeamsService } from 'src/app/core/services/teams.service';

import { TopOffensiveTeamsPageComponent } from './top-offensive-teams-page.component';

describe('TopOffensiveTeamsPageComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let service: TeamsService;
  let component: TopOffensiveTeamsPageComponent;

  beforeEach(async () => {
    service = new TeamsService(httpClientSpy);
    component = new TopOffensiveTeamsPageComponent(service);
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
