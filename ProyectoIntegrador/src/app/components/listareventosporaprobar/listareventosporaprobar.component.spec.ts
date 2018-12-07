import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListareventosporaprobarComponent } from './listareventosporaprobar.component';

describe('ListareventosporaprobarComponent', () => {
  let component: ListareventosporaprobarComponent;
  let fixture: ComponentFixture<ListareventosporaprobarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListareventosporaprobarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListareventosporaprobarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
