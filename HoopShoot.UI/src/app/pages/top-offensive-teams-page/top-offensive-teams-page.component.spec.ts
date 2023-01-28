import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopOffensiveTeamsPageComponent } from './top-offensive-teams-page.component';

describe('TopOffensiveTeamsPageComponent', () => {
  let component: TopOffensiveTeamsPageComponent;
  let fixture: ComponentFixture<TopOffensiveTeamsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopOffensiveTeamsPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TopOffensiveTeamsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
