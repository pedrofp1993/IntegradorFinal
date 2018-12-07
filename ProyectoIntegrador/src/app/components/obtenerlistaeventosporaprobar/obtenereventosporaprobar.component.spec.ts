import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenereventosporaprobarComponent } from './obtenereventosporaprobar.component';

describe('ObtenereventosporaprobarComponent', () => {
  let component: ObtenereventosporaprobarComponent;
  let fixture: ComponentFixture<ObtenereventosporaprobarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenereventosporaprobarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenereventosporaprobarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
