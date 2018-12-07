import { Component, OnInit } from '@angular/core';
import { evento } from '../entidades/evento';
import { Router, ActivatedRoute } from '@angular/router';
import { Eventoservice } from '../Services/eventoservices.service';

@Component({
  selector: 'app-obtener-evento',
  templateUrl: './obtener-evento.component.html',
  styleUrls: ['./obtener-evento.component.css']
})
export class ObtenerEventoComponent implements OnInit {
  evento:any ={} ;
  constructor(private activatedRoute: ActivatedRoute,private router: Router, private _eventoservice:Eventoservice) {
    this.activatedRoute.params.subscribe( params =>{
      this.evento = this.getEvento( params['id'] );

       console.log(this.evento);

  });
   }

  ngOnInit() {
    
  }
  getEvento(id:number){
    this._eventoservice.obtener(id).subscribe(evento => {
      console.log(evento);
      this.evento = evento;
    })
  }
  comprar(){
    window.alert("Revisa los datos de la tarjeta por favor");
  }
}
