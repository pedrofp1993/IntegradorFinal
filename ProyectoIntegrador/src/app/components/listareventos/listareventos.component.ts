import { Component, OnInit } from '@angular/core';
import { Eventoservice } from '../Services/eventoservices.service';
import { Router } from '@angular/router';
import { evento } from '../entidades/evento';

@Component({
  selector: 'app-listareventos',
  templateUrl: './listareventos.component.html',
  styleUrls: []
})
export class ListareventosComponent implements OnInit {

  evento: evento[];
  constructor(private eventoservice: Eventoservice,private router: Router) { }

  ngOnInit() {
    this.listareventos();
  }
  listareventos(){
    this.eventoservice.cargarEventoporaprobar().subscribe(evento => {
      
      this.evento=evento;
      console.log(this.evento);
    })
  }

  obtenerEvento(idx:number){
    this.router.navigate(['/ObtenerEvento',idx]);
  }
}
