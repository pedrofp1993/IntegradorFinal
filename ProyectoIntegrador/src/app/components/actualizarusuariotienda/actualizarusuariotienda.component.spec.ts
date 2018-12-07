import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarusuariotiendaComponent } from './actualizarusuariotienda.component';

describe('ActualizarusuariotiendaComponent', () => {
  let component: ActualizarusuariotiendaComponent;
  let fixture: ComponentFixture<ActualizarusuariotiendaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActualizarusuariotiendaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActualizarusuariotiendaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
