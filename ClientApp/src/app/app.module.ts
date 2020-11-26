import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { MatInputModule } from '@angular/material/input';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { ServiceWorkerModule } from '@angular/service-worker';
import { environment } from '../environments/environment';
import { LocaisComponent } from './locais/locais.component';
import { RegrasComponent } from './regras/regras.component';
import { LoginComponent } from './login/login.component';
import { UsuarioService } from './servico/usuario/usuario.service';
import { GuardRoutes } from './autorizacao/guard.routes';
import { UsuarioComponent } from './usuario/usuario.component';
import { BabaComponent } from './baba/baba.component';
import { ClienteComponent } from './cliente/cliente.component';
import { DuvidaComponent } from './duvida/duvida.component';
import { ClienteService } from './servico/cliente/cliente.service';
import { BabaService } from './servico/baba/baba.service';
import { FaleconoscoComponent } from './faleconosco/faleconosco.component';
import { CabecalhoComponent } from './cabecalho/cabecalho.component';
import { FooterComponent } from './footer/footer.component';
import { ContatoComponent } from './contato/contato.component';
import { CadastroComponent } from './cadastro/cadastro.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatNativeDateModule } from '@angular/material/core';
import { MatChipsModule, MatDialogModule } from '@angular/material';
import { LoginClienteComponent } from './login-cliente/login-cliente.component';
import { LoginBabaComponent } from './login-baba/login-baba.component';

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
    ClienteComponent,
    DuvidaComponent,
    FaleconoscoComponent,
    CabecalhoComponent,
    FooterComponent,
    ContatoComponent,
    CadastroComponent,
    LoginClienteComponent,
    LoginBabaComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    MatInputModule,
    MatNativeDateModule,
    MatDialogModule,
    MatChipsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'locais', component: LocaisComponent },
      { path: 'regras', component: RegrasComponent },
      { path: 'login', component: LoginComponent },
      { path: 'criar', component: UsuarioComponent },
      { path: 'duvida', component: DuvidaComponent },
      { path: 'baba', component: BabaComponent },
      { path: 'cliente', component: ClienteComponent },
      { path: 'contato', component: ContatoComponent },
      { path: 'cadastro', component: CadastroComponent },
      { path: 'faleconosco', component: FaleconoscoComponent}

    ]),
    ServiceWorkerModule.register('ngsw-worker.js', { enabled: environment.production }),
    BrowserAnimationsModule
  ],
  providers: [UsuarioService,
              ClienteService,
              BabaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
