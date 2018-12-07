import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ActualizarusuarioreguladorComponent } from './actualizarusuarioregulador.component';

describe('ActualizarusuarioreguladorComponent', () => {
  let component: ActualizarusuarioreguladorComponent;
  let fixture: ComponentFixture<ActualizarusuarioreguladorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ActualizarusuarioreguladorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ActualizarusuarioreguladorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
