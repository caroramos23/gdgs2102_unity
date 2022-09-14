import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { FundacionesComponent } from './fundaciones.component';
import { FundacionesRoutingModule } from './fundaciones-routing.module';
import { FundacionDialogComponent } from './components/fundacion-dialog/fundacion-dialog.component';

import { MaterialModule } from '@app/material.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    FundacionesComponent,
    FundacionDialogComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    MaterialModule,
    FundacionesRoutingModule
  ]
})
export class FundacionesModule { }
