import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PremiumCalculatorComponent } from './premium-calculator.component';

describe('PremiumCalculatorComponent', () => {
  let component: PremiumCalculatorComponent;
  let fixture: ComponentFixture<PremiumCalculatorComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PremiumCalculatorComponent]
    });
    fixture = TestBed.createComponent(PremiumCalculatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
