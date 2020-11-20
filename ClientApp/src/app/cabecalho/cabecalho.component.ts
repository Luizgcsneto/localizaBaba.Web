import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Baba } from '../model/baba';
import { Cliente } from '../model/cliente';
import { Usuario } from '../model/usuario';
import { ClienteService } from '../servico/cliente/cliente.service';

@Component({
  selector: 'app-cabecalho',
  templateUrl: './cabecalho.component.html',
  styleUrls: ['./cabecalho.component.css']
})
export class CabecalhoComponent implements OnInit {

  public usuario: Usuario;
  public cliente: Cliente;
  public baba: Baba;
  public returnUrl: string;

  constructor(private router: Router, private clienteService: ClienteService, private activateDRouter: ActivatedRoute) { }

  ngOnInit() {
    this.returnUrl = this.activateDRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
    this.cliente = new Cliente();
    this.baba = new Baba();
  }

  entrar() {
    this.clienteService.verificarCliente(this.cliente)
      .subscribe(
        data => {
          console.log(data);
        },
        err => {
          console.log(err.error);
        }
    );
  }

 

}
