import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewPatiantComponent } from './new-patiant.component';

describe('NewPatiantComponent', () => {
  let component: NewPatiantComponent;
  let fixture: ComponentFixture<NewPatiantComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NewPatiantComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NewPatiantComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
