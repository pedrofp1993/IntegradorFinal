import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerEventoComponent } from './obtener-evento.component';

describe('ObtenerEventoComponent', () => {
  let component: ObtenerEventoComponent;
  let fixture: ComponentFixture<ObtenerEventoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenerEventoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenerEventoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
