import { Component, OnInit } from '@angular/core';
import { Eventoservice } from '../Services/eventoservices.service';
import { Router } from '@angular/router';
import { eventoaprobar } from '../entidades/eventosxaprobar';

@Component({
  selector: 'app-obtenereventosporaprobar',
  templateUrl: './obtenereventosporaprobar.component.html',
  styleUrls: ['./obtenereventosporaprobar.component.css']
})
export class ObtenereventosporaprobarComponent implements OnInit {
  evento: eventoaprobar[];
  even:eventoaprobar;
  bulean: boolean;
  constructor(private eventoservice: Eventoservice,private router: Router) { }
  
  ngOnInit() {
    this.listareventos();
  }
  listareventos(){
    this.eventoservice.obtenerxaprobar().subscribe(evento => {
      
      this.evento=evento;
      console.log(this.evento);
    })
  }

  obtenerEvento(idx:number){
    this.aprobar
  }
  aprobar(evento:eventoaprobar){
    this.even;
    this.eventoservice.actualizarEventoaaprobado(this.even)
      .subscribe(data => {
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));
        window.alert("Se aprobo el evento");
        this.router.navigate(['/Obtenereventosporaprobar']);
      
    
  }
  desaprobar(){
    this.even;
    this.eventoservice.actualizarEventoadesaprobado(this.even)
      .subscribe(data => {
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));
        window.alert("Se desaprobo el evento");
        this.router.navigate(['/Obtenereventosporaprobar']);
  }
}
