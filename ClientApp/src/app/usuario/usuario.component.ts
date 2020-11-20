import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { UsuarioService } from '../servico/usuario/usuario.service';

@Component({
  selector: 'app-usuario',
  templateUrl: './usuario.component.html',
  styleUrls: ['./usuario.component.css']
})
export class UsuarioComponent implements OnInit {

  constructor(private router: Router, private usuarioServico: UsuarioService) { }

  ngOnInit()
  {
  }

  voltar()
  {
    this.router.navigate(['/']);
  }

}
