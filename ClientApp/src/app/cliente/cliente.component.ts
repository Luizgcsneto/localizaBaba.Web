import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Cliente } from '../model/cliente';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  public cliente: Cliente;

  constructor(private router: Router) { }


  ngOnInit() {

    this.cliente = new Cliente();
  }

  voltar() {
    this.router.navigate(['/']);
  }

  cadastrar() {

  }

}
