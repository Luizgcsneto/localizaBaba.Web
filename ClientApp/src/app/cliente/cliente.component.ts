import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Cliente } from '../model/cliente';
import { ClienteService } from '../servico/cliente/cliente.service';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  clienteForm: FormGroup;
  public cliente: Cliente;
  public clientes: Cliente[];

  constructor(private router: Router, private fb: FormBuilder, private clienteService: ClienteService) { }

  ngOnInit() {

    this.clienteForm = this.fb.group({
      nome: ['', [Validators.required]],
      CPF: ['', [Validators.required]],
      email: ['', [Validators.required]],
      senha: ['', [Validators.required]],
      endereco: ['', [Validators.required]],
      cidade: ['', [Validators.required]],
      estado: ['', [Validators.required]],
      CEP: ['', [Validators.required]],
    });

    this.cliente = new Cliente();
    this.clientes = new Array<Cliente>();
  }

  voltar() {
    this.router.navigate(['/']);
  }

  cadastrarCliente(form) {
    this.clientes.push(form.value)

    this.cliente.nome = "";
    this.cliente.CEP = "";
    this.cliente.cidade = "";
    this.cliente.email = "";
    this.cliente.endereco = "";
    this.cliente.CPF = null;
    this.cliente.estado = "";


  }

   OnSubmit() {
    
   
  }


}
