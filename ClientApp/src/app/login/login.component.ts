import { Component, OnInit } from "@angular/core";
import { Usuario } from "../model/usuario";
import { Router, ActivatedRoute } from '@angular/router';
import { UsuarioService } from "../servico/usuario.service";


@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {


  public usuario: Usuario;
  public nome: string;
  public email: string;
  public returnUrl: string;
  public mensagem: string;
  public strModelo: string;
  public ativar_spinner: boolean;


  constructor(private router: Router, private activateRoute: ActivatedRoute, private usuarioService: UsuarioService) { }

  ngOnInit(): void {
    this.returnUrl = this.activateRoute.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {

    this.ativar_spinner = true;
    let user = new Usuario();

    this.usuarioService.verificarUsuario(this.usuario)
      .subscribe(
        data => {
          user = data;
          this.usuarioService.usuario = data;

          this.nome = user.nome;
          this.email = user.email;
          var pegouEmail = this.isEmail(this.email);

          if (this.usuario != null && pegouEmail == true) {
            this.router.navigate(['/']);
          } else {
            this.router.navigate(['/produto']);
          }

        },
        err => {
          console.log(err.error);
          this.mensagem = err.error;
          this.ativar_spinner = false;
        });
  }

  public isEmail(email): boolean {

    var reg = /^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/
    if (reg.test(email)) {
      return true;
    }
    else {
      return false;
    }

  }





}
