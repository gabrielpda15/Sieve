import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SystemGuardService } from './shared/systemguard.service';


const routes: Routes = [
  {
    path: 'system',
    loadChildren: () => import('./system/system.module').then(m => m.SystemModule)/*,
    canActivate: [SystemGuardService]*/
  },
  {
    path: '',
    loadChildren: () => import('./home/home.module').then(m => m.HomeModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
