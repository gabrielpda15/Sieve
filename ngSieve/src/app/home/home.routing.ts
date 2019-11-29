import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home.component';
import { AboutComponent } from './about/about.component';
import { HomeContentComponent } from './content/content.component';

const childRoutes: Routes = [
  { path: 'about', component: AboutComponent },
  { path: '', component: HomeContentComponent }
];

const routes: Routes = [
  { path: '', component: HomeComponent, children: childRoutes }
];

export const routing = RouterModule.forChild(routes);
