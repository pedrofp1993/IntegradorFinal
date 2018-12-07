import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Eventoservice } from '../Services/eventoservices.service';

@Component({
  selector: 'app-obtenereventoaprobar',
  templateUrl: './obtenereventoaprobar.component.html',
  styleUrls: ['./obtenereventoaprobar.component.css']
})
export class ObtenereventoaprobarComponent implements OnInit {

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
    this._eventoservice.calificarevento(id).subscribe(evento => {
      
      this.evento = evento;
      console.log(evento);
    })
  }
}
