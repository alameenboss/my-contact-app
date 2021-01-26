import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddressComponent } from './component/address/address.component';
import { ListPersonComponent } from './component/list-person/list-person.component';
import { PersonDropComponent } from './component/person-drop/person-drop.component';
import { PersonTreeComponent } from './component/person-tree/person-tree.component';

import { DashboardComponent } from './component/dashboard/dashboard.component';
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
