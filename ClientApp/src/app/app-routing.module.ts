import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EstampillaComponent } from './estampilla/estampilla.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: 'calculoEstampilla',
    component: EstampillaComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ]
})
export class AppRoutingModule { }
