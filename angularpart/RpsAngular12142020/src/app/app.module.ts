import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { OktaAuthModule } from '@okta/okta-angular';

import { AppComponent } from './app.component';
import { LoginPlayerComponent } from './login-player/login-player.component';
import { PlayerdetailsComponent } from './playerdetails/playerdetails.component';
import { RoutingModule } from './routing.module';
import { PlayerListComponent } from './player-list/player-list.component';
import { EditPlayerComponent } from './edit-player/edit-player.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginPlayerComponent,
    PlayerdetailsComponent,
    PlayerListComponent,
    EditPlayerComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RoutingModule,
    OktaAuthModule.initAuth({
      issuer: 'https://dev-06780650.okta.com/oauth2/default',
      redirectUri: 'http://localhost:4200/implicit/callback',
      clientId: '0oa4j9ionxbcW6CBJ5d6'
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
