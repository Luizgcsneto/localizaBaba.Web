import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Baba } from '../model/baba';
import { BabaService } from '../servico/baba/baba.service';

@Component({
  selector: 'app-baba',
  templateUrl: './baba.component.html',
  styleUrls: ['./baba.component.css']
})
export class BabaComponent implements OnInit {

  public baba: Baba;

  constructor(private router: Router, private babaService: BabaService) { }

  ngOnInit() {

    this.baba = new Baba();
  }

  voltar() {
    this.router.navigate(['/']);
  }

  cadastrar() {

  }

}
