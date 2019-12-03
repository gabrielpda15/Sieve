import { RouterModule, Routes } from '@angular/router';
import { SystemComponent } from './system.component';

const childRoutes: Routes = [
  { path: 'storage', loadChildren: () => import('./storage/storage.module').then(m => m.StorageModule) }
];

const routes: Routes = [
  { path: '', component: SystemComponent, children: childRoutes }
];

export const routing = RouterModule.forChild(routes);
