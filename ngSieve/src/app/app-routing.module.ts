import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SystemGuardService } from './shared/systemguard.service';


const routes: Routes = [
  {
    path: '',
    loadChildren: () => import('./home/home.module').then(m => m.HomeModule)
  },
  {
    path: '',
    loadChildren: () => import('./system/system.module').then(m => m.SystemModule),
    canActivate: [SystemGuardService]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
