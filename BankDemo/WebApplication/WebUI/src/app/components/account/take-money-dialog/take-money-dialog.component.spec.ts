import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TakeMoneyDialogComponent } from './take-money-dialog.component';

describe('TakeMoneyDialogComponent', () => {
  let component: TakeMoneyDialogComponent;
  let fixture: ComponentFixture<TakeMoneyDialogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TakeMoneyDialogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(TakeMoneyDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
