import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrousuariojugadorComponent } from './registrousuariojugador.component';

describe('RegistrousuariojugadorComponent', () => {
  let component: RegistrousuariojugadorComponent;
  let fixture: ComponentFixture<RegistrousuariojugadorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrousuariojugadorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrousuariojugadorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
