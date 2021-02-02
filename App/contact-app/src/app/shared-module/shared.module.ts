import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MaterialModule } from 'src/app/shared-module/material/material.module';
import { ConfiramtionComponent } from '../pages/shared/confiramtion/confiramtion.component';
import { SpinnerOverlayComponent } from '../pages/shared/spinner-overlay/spinner-overlay.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    MaterialModule
  ],
  declarations: [ConfiramtionComponent,SpinnerOverlayComponent]
})
export class SharedModule { }
