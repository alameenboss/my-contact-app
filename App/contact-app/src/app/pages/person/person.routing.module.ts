import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { ListPersonComponent } from './list-person/list-person.component';

const routes: Routes = [
  { path: '', component: ListPersonComponent },
  { path: 'addperson', component: ListPersonComponent},
  { path: 'editperson/:id', component: ListPersonComponent}
]
@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forChild(routes)
  ]
})
export class PersonRoutingModule { }
