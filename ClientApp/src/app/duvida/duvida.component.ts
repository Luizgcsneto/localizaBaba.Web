import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-duvida',
  templateUrl: './duvida.component.html',
  styleUrls: ['./duvida.component.css']
})
export class DuvidaComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit() {
  }

  voltar() {
    this.router.navigate(['/']);
  }

}
