import { HttpClient } from '@angular/common/http';
import { TeamsService } from 'src/app/core/services/teams.service';
import { AllTeamsPageComponent } from './all-teams-page.component';

describe('AllTeamsPageComponent', () => {
  let httpClientSpy: jasmine.SpyObj<HttpClient>;
  let service: TeamsService;
  let component: AllTeamsPageComponent;

  beforeEach(async () => {
    service = new TeamsService(httpClientSpy);
    component = new AllTeamsPageComponent(service);
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
