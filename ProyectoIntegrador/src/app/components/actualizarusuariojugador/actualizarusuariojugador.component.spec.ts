import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarusuariojugadorComponent } from './actualizarusuariojugador.component';

describe('ActualizarusuariojugadorComponent', () => {
  let component: ActualizarusuariojugadorComponent;
  let fixture: ComponentFixture<ActualizarusuariojugadorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActualizarusuariojugadorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActualizarusuariojugadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
