import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchResultsPageComponent } from './match-results-page.component';

describe('MatchResultsPageComponent', () => {
  let component: MatchResultsPageComponent;
  let fixture: ComponentFixture<MatchResultsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MatchResultsPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MatchResultsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
