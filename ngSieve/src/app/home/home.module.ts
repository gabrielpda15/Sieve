import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { routing } from './home.routing';
import { HomeContentComponent } from './content/content.component';
import { AboutComponent } from './about/about.component';
import { LoginComponent } from './login/login.component';
import { LoginService } from './login/login.service';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [HomeComponent, HomeContentComponent, AboutComponent, LoginComponent],
  imports: [ CommonModule, routing, SharedModule ],
  providers: [ LoginService ]
})
export class HomeModule { }
