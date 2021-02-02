import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ListPersonComponent } from './list-person/list-person.component';
import { AddEditPersonComponent } from './add-edit-person/add-edit-person.component';

const routes: Routes = [
  { path: '', component: ListPersonComponent },
  { path: 'addperson', component: AddEditPersonComponent},
  { path: 'editperson/:id', component: AddEditPersonComponent}
]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class PersonRoutingModule { }
