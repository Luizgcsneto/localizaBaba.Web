import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { Cliente } from '../model/cliente';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  clienteForm: FormGroup;
  public cliente: Cliente;

  constructor(private router: Router, private fb: FormBuilder, private http: HttpClient) { }

  ngOnInit() {

    this.clienteForm = this.fb.group({
      nome: [''],
      CPF: [''],
      email: [''],
      senha: [''],
      endereco: [''],
      cidade: [''],
      estado: [''],
      CEP: ['']
    });

    this.cliente = new Cliente();
  }

  voltar() {
    this.router.navigate(['/']);
  }

  cadastrar() {

  }

  OnSubmit() {
    this.http.post('https://localhost:44341/api/cliente', this.clienteForm).subscribe(
      data => {
        console.log(data);
      }
    );
  }


}
