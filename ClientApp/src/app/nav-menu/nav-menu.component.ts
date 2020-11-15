import { Component } from '@angular/core';
import { Usuario } from '../model/usuario';
import { UsuarioService } from '../servico/usuario.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  public ativar_spinner: boolean;
  public mensagem: string;
  private usuario: Usuario;

  constructor(private usuarioService: UsuarioService) {
    this.usuario = new Usuario;
  }

  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  entrar() {

    this.ativar_spinner = true;
    let user = new Usuario();

   
  }

}
