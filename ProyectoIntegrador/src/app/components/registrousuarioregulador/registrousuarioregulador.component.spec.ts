import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RegistrousuarioreguladorComponent } from './registrousuarioregulador.component';

describe('RegistrousuarioreguladorComponent', () => {
  let component: RegistrousuarioreguladorComponent;
  let fixture: ComponentFixture<RegistrousuarioreguladorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RegistrousuarioreguladorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RegistrousuarioreguladorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
