import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenereventoaprobarComponent } from './obtenereventoaprobar.component';

describe('ObtenereventoaprobarComponent', () => {
  let component: ObtenereventoaprobarComponent;
  let fixture: ComponentFixture<ObtenereventoaprobarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenereventoaprobarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenereventoaprobarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
