import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Baba } from '../model/baba';

@Component({
  selector: 'app-baba',
  templateUrl: './baba.component.html',
  styleUrls: ['./baba.component.css']
})
export class BabaComponent implements OnInit {

  public baba: Baba;

  constructor(private router: Router) { }

  ngOnInit() {

    this.baba = new Baba();
  }

  voltar() {
    this.router.navigate(['/']);
  }

  cadastrar() {

  }

}
