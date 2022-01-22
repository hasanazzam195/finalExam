import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { RouterModule, Routes } from '@angular/router';
import {HttpClientModule }from '@angular/common/http'
import { FormsModule } from '@angular/forms';
import { NewPatiantComponent } from './new-patiant/new-patiant.component';
import { DepartmentComponent } from './department/department.component';
import { PatiantListComponent } from './patiant-list/patiant-list.component';
import { PatiantService} from 'src/Service/patiant'
import {DepartmentService} from 'src/Service/deparmentService'
const AppRoutes:Routes=[
  {path:'',component:NewPatiantComponent},
  {path:'patiantlist',component:PatiantListComponent},
  {path:'department',component:DepartmentComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NewPatiantComponent,
    DepartmentComponent,
    PatiantListComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(AppRoutes),
    HttpClientModule,
    FormsModule
  ],
  providers: [PatiantService,
    DepartmentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
