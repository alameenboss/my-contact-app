import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavigationComponent } from './component/navigation/navigation.component';
import { AddressComponent } from './component/address/address.component';
import { ListPersonComponent } from './component/list-person/list-person.component';
import { PersonTreeComponent } from './component/person-tree/person-tree.component';
import { PersonDropComponent } from './component/person-drop/person-drop.component';
import { CardComponent } from './component/card/card.component';
import { DashboardComponent } from './component/dashboard/dashboard.component';
import { HttpClientModule } from '@angular/common/http';
import { MaterialModule } from './shared-module/material/material.module';
@NgModule({
  declarations: [
    AppComponent,
    NavigationComponent,
    AddressComponent,
    ListPersonComponent,
    PersonTreeComponent,
    PersonDropComponent,
    CardComponent,
    DashboardComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
