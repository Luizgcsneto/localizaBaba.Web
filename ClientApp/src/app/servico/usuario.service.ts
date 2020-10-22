import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from '../model/usuario';
import { Router } from '@angular/router';


@Injectable({
  providedIn: 'root'
})
export class UsuarioService implements OnInit {

  private baseURL: string;
  private _usuario: Usuario;
  public usuarios: Usuario[];

  set usuario(usuario: Usuario) {
    sessionStorage.setItem("usuario-autenticado", JSON.stringify(usuario));
    this._usuario = usuario;
  }

  get usuario(): Usuario {
    let usuario_json = sessionStorage.getItem("usuario-autenticado");
    this._usuario = JSON.parse(usuario_json);
    return this._usuario;
  }

  get header(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'application/json')
      .set("Access-Control-Allow-Origin", "*")
      .set("Access-Control-Allow-Methods", "GET,HEAD,OPTIONS,POST,PUT");
  }

  public usuario_autenticado(): boolean {
    return this._usuario != null && this._usuario.email != "" && this._usuario.senha != "";
  }


  public limpar_sessao() {
    sessionStorage.setItem("usuario-autenticado", "");
    this._usuario = null;
  }


  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }

  ngOnInit(): void {
    this.usuarios = [];
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario> {


    // this.baseURL = raiz do site que pode ser exemplo.: www.rkcomex.com.br
    let retorno = this.http.post<Usuario>("https://localhost:44/api/Usuario/VerificarUsuario", usuario, { headers: this.header });

    return retorno;


  }

  public cadastrarUsuario(usuario: Usuario): Observable<Usuario> {

    return this.http.post<Usuario>("https://localhost:44341/api/usuario", JSON.stringify(usuario), { headers: this.header });

  }

  public salvarUsuario(usuario: Usuario): Observable<Usuario> {

    return this.http.post<Usuario>("https://localhost:44341/api/usuario/salvarUsuario", JSON.stringify(usuario), { headers: this.header });

  }

  public deletarUsuario(usuario: Usuario): Observable<Usuario> {

    return this.http.post<Usuario>("https://localhost:44341/api/usuario/deletarUsuario", JSON.stringify(usuario), { headers: this.header });

  }


  public obterTodosUsuarios(): Observable<Usuario[]> {

    return this.http.get<Usuario[]>("https://localhost:44341/api/usuario");

  }

  public obterUsuario(usuarioId: number): Observable<Usuario> {

    return this.http.get<Usuario>("https://localhost:44341/api/usuario");
  }

}




