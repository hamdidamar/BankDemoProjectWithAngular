import { NgModule } from '@angular/core'
import { RouterModule, Routes } from '@angular/router'
import { AccountComponent } from './components/account/account.component'
import { AddMoneyDialogComponent } from './components/account/add-money-dialog/add-money-dialog.component'
import { TakeMoneyDialogComponent } from './components/account/take-money-dialog/take-money-dialog.component'
import { LoginComponent } from './components/login/login.component'
import { RegisterComponent } from './components/register/register.component'
import { HomeComponent } from './home/home.component'

const routes: Routes = [
  {
    component: HomeComponent,
    path: '',
  },
  {
    component: LoginComponent,
    path: 'login',
  },
  {
    component: RegisterComponent,
    path: 'register',
  },
  {
    component: AccountComponent,
    path: 'account',
  },
  {
    component: AddMoneyDialogComponent,
    path: 'addMoney/:item',
  },
  {
    component: TakeMoneyDialogComponent,
    path: 'takeMoney/:item',
  }


]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
