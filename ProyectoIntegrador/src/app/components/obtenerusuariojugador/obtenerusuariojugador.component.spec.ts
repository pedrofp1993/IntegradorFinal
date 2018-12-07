import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerusuariojugadorComponent } from './obtenerusuariojugador.component';

describe('ObtenerusuariojugadorComponent', () => {
  let component: ObtenerusuariojugadorComponent;
  let fixture: ComponentFixture<ObtenerusuariojugadorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenerusuariojugadorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenerusuariojugadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
