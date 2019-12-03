import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SystemComponent } from './system.component';
import { routing } from './system.routing';



@NgModule({
  declarations: [ SystemComponent ],
  imports: [ CommonModule, routing ]
})
export class SystemModule { }
