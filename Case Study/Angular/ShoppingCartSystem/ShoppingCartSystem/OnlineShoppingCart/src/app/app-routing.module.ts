import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { SettingsComponent } from './settings/settings.component';
import { ForgotPasswordComponent } from './settings/forgot-password/forgot-password.component';
import { AddAddressComponent } from './add-address/add-address.component';
import { ResetPasswordComponent } from './settings/reset-password/reset-password.component';

const routes: Routes = [
  { path: 'home-page', component: HomePageComponent },
  {path:'login',component:LoginComponent},
  {path:'register',component:RegisterComponent},
  {path:'settings',component:SettingsComponent},
  {path:'forgot-password',component:ForgotPasswordComponent},
  {path:'add-address',component:AddAddressComponent},
  {path:'reset-password',component:ResetPasswordComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
