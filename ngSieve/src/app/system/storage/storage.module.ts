import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StorageComponent } from './storage.component';
import { ProductsComponent } from './products/products.component';
import { ProductsService } from './products/products.service';
import { routing } from './storage.routing';



@NgModule({
  declarations: [ StorageComponent, ProductsComponent ],
  imports: [ CommonModule, routing ],
  providers: [ ProductsService ]
})
export class StorageModule { }
