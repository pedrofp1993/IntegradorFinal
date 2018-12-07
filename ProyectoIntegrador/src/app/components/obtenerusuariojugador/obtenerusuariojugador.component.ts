import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuariojugadorservice } from '../Services/usuariojugador.service';


@Component({
  selector: 'app-obtenerusuariojugador',
  templateUrl: './obtenerusuariojugador.component.html',
  styleUrls: []
})
export class ObtenerusuariojugadorComponent implements OnInit {
  usuario: any;
  constructor(private _usuariojugadorService: Usuariojugadorservice,private router:Router) {
    this.getJugador(1);
   }

  ngOnInit() {
  }
  getJugador(id:number){
    this._usuariojugadorService.obtener(id).subscribe(usuario => {
      console.log(usuario);
      this.usuario = usuario;
    })
  }
}
