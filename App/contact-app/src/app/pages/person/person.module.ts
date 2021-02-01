import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonRoutingModule } from './person.routing.module';
import { ListPersonComponent } from './list-person/list-person.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from 'src/app/shared-module/material/material.module';

@NgModule({
  imports: [
    CommonModule,
    PersonRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule
  ],
  declarations: [ListPersonComponent]
})
export class PersonModule { }
