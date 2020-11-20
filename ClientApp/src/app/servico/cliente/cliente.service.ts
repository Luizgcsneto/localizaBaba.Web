import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Router } from '@angular/router';
import { Cliente } from '../../model/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService implements OnInit {

  private baseURL: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseURL = baseUrl;
  }
  private cliente: Cliente;

  ngOnInit(): void {
       
  }

  public verificarCliente(cliente: Cliente): Observable<Cliente> {

    const headers = new HttpHeaders().set('content-type', 'application/json');

    var body = {
      email: cliente.email,
      senha: cliente.senha
    }

    return this.http.post<Cliente>(this.baseURL + "api/cliente/verificarCliente", body, { headers });

  }

}
