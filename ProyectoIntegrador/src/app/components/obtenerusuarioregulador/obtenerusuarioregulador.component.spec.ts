import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerusuarioreguladorComponent } from './obtenerusuarioregulador.component';

describe('ObtenerusuarioreguladorComponent', () => {
  let component: ObtenerusuarioreguladorComponent;
  let fixture: ComponentFixture<ObtenerusuarioreguladorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenerusuarioreguladorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenerusuarioreguladorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
