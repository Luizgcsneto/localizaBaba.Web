import { Injectable, Inject, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Router } from '@angular/router';
import { Baba } from '../model/baba';


@Injectable({
  providedIn: 'root'
})
export class BabaService implements OnInit {


  private baba: Baba;

  ngOnInit(): void {
     
  }
  
}
