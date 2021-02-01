import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddressComponent } from './component/address/address.component';
import { PersonDropComponent } from './component/person-drop/person-drop.component';
import { PersonTreeComponent } from './component/person-tree/person-tree.component';

import { DashboardComponent } from './component/dashboard/dashboard.component';
import { AuthGuard } from './authentication/auth.guard';
import { LoginComponent } from './authentication/login/login.component';
import { AdminComponent } from './component/admin/admin.component';
import { HomeComponent } from './component/home/home.component';
import { Role } from './models/role';
const routes: Routes = [
  { path: '', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'person', loadChildren: () => import('src/app/pages/person/person.module').then(p => p.PersonModule),canActivate:[AuthGuard] ,data: { path: 'person' }},
  { path: 'addaddress', component: AddressComponent, canActivate: [AuthGuard] },
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
