import { Component, OnInit } from '@angular/core';
import{ evento } from "../entidades/evento";
import { Router } from "@angular/router";
import { Eventoservice } from '../Services/eventoservices.service';
@Component({
  selector: 'app-listareventosporaprobar',
  templateUrl: './listareventosporaprobar.component.html',
  styleUrls: ['./listareventosporaprobar.component.css']
})
export class ListareventosporaprobarComponent implements OnInit {

  evento: evento[];
  constructor(private _eventoService: Eventoservice,
    private _router:Router) { }

  ngOnInit() {
  }
  obtener(){
    this._eventoService.cargarEventoporaprobar().subscribe(evento => {
      console.log(this.evento);
      this.evento=evento;
    })
  }
}
