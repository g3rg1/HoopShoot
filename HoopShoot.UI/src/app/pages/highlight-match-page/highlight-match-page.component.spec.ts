import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HighlightMatchPageComponent } from './highlight-match-page.component';

describe('HighlightMatchPageComponent', () => {
  let component: HighlightMatchPageComponent;
  let fixture: ComponentFixture<HighlightMatchPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HighlightMatchPageComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HighlightMatchPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
