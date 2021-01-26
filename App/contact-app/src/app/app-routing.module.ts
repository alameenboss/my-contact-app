import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddressComponent } from './component/address/address.component';
import { ListPersonComponent } from './component/list-person/list-person.component';
import { PersonDropComponent } from './component/person-drop/person-drop.component';
import { PersonTreeComponent } from './component/person-tree/person-tree.component';

import { DashboardComponent } from './component/dashboard/dashboard.component';
import { AuthGuard } from './authentication/auth.guard';
import { LoginComponent } from './component/login/login.component';
import { AdminComponent } from './component/admin/admin.component';
import { HomeComponent } from './component/home/home.component';
import { Role } from './models/role';
const routes: Routes = [
  { path: '', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'addaddress', component: AddressComponent, canActivate: [AuthGuard] },
  { path: 'listperson', component: ListPersonComponent, canActivate: [AuthGuard] },
  { path: 'presontree', component: PersonTreeComponent, canActivate: [AuthGuard] },
  { path: 'presondrop', component: PersonDropComponent, canActivate: [AuthGuard] },
  { path: 'home',component: HomeComponent,canActivate: [AuthGuard]},
  { path: 'admin',component: AdminComponent,canActivate: [AuthGuard],data: { roles: [Role.Admin] }},
  { path: 'login',component: LoginComponent},
  // otherwise redirect to home
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
