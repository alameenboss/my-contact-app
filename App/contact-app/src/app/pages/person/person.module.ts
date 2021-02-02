import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonRoutingModule } from './person.routing.module';
import { ListPersonComponent } from './list-person/list-person.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from 'src/app/shared-module/material/material.module';
import { SharedModule } from 'src/app/shared-module/shared.module';
import { AddEditPersonComponent } from './add-edit-person/add-edit-person.component';

@NgModule({
  imports: [
    CommonModule,
    PersonRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule,
    SharedModule
  ],
  declarations: [ListPersonComponent, AddEditPersonComponent]
})
export class PersonModule { }
