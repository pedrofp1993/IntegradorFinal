import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ObtenerusuariotiendaComponent } from './obtenerusuariotienda.component';

describe('ObtenerusuariotiendaComponent', () => {
  let component: ObtenerusuariotiendaComponent;
  let fixture: ComponentFixture<ObtenerusuariotiendaComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ObtenerusuariotiendaComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ObtenerusuariotiendaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
