import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrousuariotiendaComponent } from './registrousuariotienda.component';

describe('RegistrousuariotiendaComponent', () => {
  let component: RegistrousuariotiendaComponent;
  let fixture: ComponentFixture<RegistrousuariotiendaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrousuariotiendaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrousuariotiendaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
