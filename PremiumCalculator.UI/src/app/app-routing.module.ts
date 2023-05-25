import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PremiumCalculatorComponent } from './premium-calculator/premium-calculator.component';

const routes: Routes = [
  { path: 'premium', component: PremiumCalculatorComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }