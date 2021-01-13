import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddressComponent } from './address/address.component';
import { ListPersonComponent } from './list-person/list-person.component';
import { PersonDropComponent } from './person-drop/person-drop.component';
import { PersonTreeComponent } from './person-tree/person-tree.component';

import { DashboardComponent } from './dashboard/dashboard.component';
const routes: Routes = [
  { path: '', component: DashboardComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'addaddress', component: AddressComponent },
  { path: 'listperson', component: ListPersonComponent },
  { path: 'presontree', component: PersonTreeComponent },
  { path: 'presondrop', component: PersonDropComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
