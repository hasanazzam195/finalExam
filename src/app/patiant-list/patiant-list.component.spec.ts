import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PatiantListComponent } from './patiant-list.component';

describe('PatiantListComponent', () => {
  let component: PatiantListComponent;
  let fixture: ComponentFixture<PatiantListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PatiantListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PatiantListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
