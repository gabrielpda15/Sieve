import { Routes, RouterModule } from '@angular/router';
import { StorageComponent } from './storage.component';
import { ProductsComponent } from './products/products.component';

const routes: Routes = [
  { path: 'products', component: ProductsComponent },
  { path: '', component: StorageComponent }
];

export const routing = RouterModule.forChild(routes);
