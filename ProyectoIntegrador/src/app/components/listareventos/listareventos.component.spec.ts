import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListareventosComponent } from './listareventos.component';

describe('ListareventosComponent', () => {
  let component: ListareventosComponent;
  let fixture: ComponentFixture<ListareventosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListareventosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListareventosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
