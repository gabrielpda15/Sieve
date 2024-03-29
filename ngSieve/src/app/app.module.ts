import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { SessionService } from './shared/session.service';
import { SystemGuardService } from './shared/systemguard.service';
import { HomeModule } from './home/home.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    HomeModule
  ],
  providers: [SessionService, SystemGuardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
