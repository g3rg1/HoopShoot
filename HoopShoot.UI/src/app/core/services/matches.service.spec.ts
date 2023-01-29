import { HttpClient } from '@angular/common/http';
import { TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { Match } from 'src/app/shared/models/match.model';

import { MatchesService } from './matches.service';

describe('MatchesService', () => {
  let service: MatchesService;
  let httpClientSpy: jasmine.SpyObj<HttpClient>;

  beforeEach(() => {
    httpClientSpy = jasmine.createSpyObj('HttpClient', ['get']);
    service = new MatchesService(httpClientSpy);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should return expected matches', (done: DoneFn) => {
    const expectedMatches: Match[] = [ 
      new Match(1, 1, "bulls", 2, "suns", 100, 20),
       new Match(1, 1, "bulls", 2, "suns", 100, 20)
      ];
    httpClientSpy.get.and.returnValue(of(expectedMatches));

    service.getMatches().subscribe({
      next: matches => {
        expect(matches)
          .withContext('expected matches')
          .toEqual(expectedMatches);
        done();
      },
      error: done.fail
    });
    expect(httpClientSpy.get.calls.count())
      .withContext('one call')
      .toBe(1);
  });

  it('should return expected highlight match', (done: DoneFn) => {
    const expectedMatch: Match = new Match(1, 1, "bulls", 2, "suns", 100, 20);
    httpClientSpy.get.and.returnValue(of(expectedMatch));

    service.getHighLightMatch().subscribe({
      next: match => {
        expect(match)
          .withContext('expected highlight match')
          .toEqual(expectedMatch);
        done();
      },
      error: done.fail
    });
    expect(httpClientSpy.get.calls.count())
      .withContext('one call')
      .toBe(1);
  });
});
