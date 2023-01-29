import { HttpClient } from '@angular/common/http';
import { of } from 'rxjs';
import { MatchQuery } from 'src/app/shared/models/matchQuery.model';
import { Team } from 'src/app/shared/models/team.model';
import { TeamsService } from './teams.service';

describe('TeamsService', () => {
  let service: TeamsService;
  let httpClientSpy: jasmine.SpyObj<HttpClient>;

  beforeEach(() => {
    httpClientSpy = jasmine.createSpyObj('HttpClient', ['get']);
    service = new TeamsService(httpClientSpy)
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should return expected teams', (done: DoneFn) => {
    const expectedTeams: Team[] = [ new Team(1, "bulls"), new Team(2, "suns")];
    httpClientSpy.get.and.returnValue(of(expectedTeams));

    service.getTeams().subscribe({
      next: teams => {
        expect(teams)
          .withContext('expected teams')
          .toEqual(expectedTeams);
        done();
      },
      error: done.fail
    });
    expect(httpClientSpy.get.calls.count())
      .withContext('one call')
      .toBe(1);
  });

  it('should return top defensive teams', (done: DoneFn) => {
    const expectedTeams: MatchQuery[] = [ 
      new MatchQuery(100, 1, 1, "wolves", 2, "bulls", 100, 50), 
      new MatchQuery(100, 1, 1, "wolves", 2, "bulls", 100, 50)
    ];
      
    httpClientSpy.get.and.returnValue(of(expectedTeams));

    service.getTopDefensive().subscribe({
      next: defensiveTeams => {
        expect(defensiveTeams)
          .withContext('expected defensive teams')
          .toEqual(expectedTeams);
        done();
      },
      error: done.fail
    });
    expect(httpClientSpy.get.calls.count())
      .withContext('one call')
      .toBe(1);
  });

  it('should return top Offensive teams', (done: DoneFn) => {
    const expectedTeams: MatchQuery[] = [
       new MatchQuery(100, 1, 1, "wolves", 2, "bulls", 100, 50),
        new MatchQuery(100, 1, 1, "wolves", 2, "bulls", 100, 50)
      ];
    httpClientSpy.get.and.returnValue(of(expectedTeams));

    service.getTopOffensive().subscribe({
      next: offensiveTeams => {
        expect(offensiveTeams)
          .withContext('expected offensive teams')
          .toEqual(expectedTeams);
        done();
      },
      error: done.fail
    });
    expect(httpClientSpy.get.calls.count())
      .withContext('one call')
      .toBe(1);
  });
});

