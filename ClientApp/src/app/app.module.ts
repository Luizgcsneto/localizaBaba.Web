import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { LocaisComponent } from './locais/locais.component';
import { RegrasComponent } from './regras/regras.component';
import { LoginComponent } from './login/login.component';
import { UsuarioService } from './servico/usuario.service';
import { GuardRoutes } from './autorizacao/guard.routes';
import { UsuarioComponent } from './usuario/usuario.component';
import { BabaComponent } from './baba/baba.component';
import { ClienteComponent } from './cliente/cliente.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    LocaisComponent,
    RegrasComponent,
    LoginComponent,
    UsuarioComponent,
    BabaComponent,
    ClienteComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'locais', component: LocaisComponent },
      { path: 'regras', component: RegrasComponent },
      { path: 'login', component: LoginComponent },
      { path: 'criar', component: UsuarioComponent },

    ]),
    ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production })
  ],
  providers: [UsuarioService],
  bootstrap: [AppComponent]
})
export class AppModule { }
