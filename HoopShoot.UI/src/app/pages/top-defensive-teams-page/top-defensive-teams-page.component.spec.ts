import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TopDefensiveTeamsPageComponent } from './top-defensive-teams-page.component';

describe('TopDefensiveTeamsPageComponent', () => {
  let component: TopDefensiveTeamsPageComponent;
  let fixture: ComponentFixture<TopDefensiveTeamsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TopDefensiveTeamsPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TopDefensiveTeamsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
