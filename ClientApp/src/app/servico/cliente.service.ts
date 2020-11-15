import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Router } from '@angular/router';
import { Cliente } from '../model/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService implements OnInit {

  private cliente: Cliente;

  ngOnInit(): void {
       
    }

}
