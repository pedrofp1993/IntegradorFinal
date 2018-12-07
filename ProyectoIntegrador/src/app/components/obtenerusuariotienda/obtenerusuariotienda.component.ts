import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuariotiendaservice } from '../Services/usuariotienda.service';
@Component({
  selector: 'app-obtenerusuariotienda',
  templateUrl: './obtenerusuariotienda.component.html',
  styleUrls: []
})
export class ObtenerusuariotiendaComponent implements OnInit {
  usuario: any;
  constructor(private _usuariotiendaService: Usuariotiendaservice,private router:Router) {
    this.getRegulador(1);
   }

  ngOnInit() {
  }
  getRegulador(id:number){
    this._usuariotiendaService.obtener(id).subscribe(usuario => {
      console.log(usuario);
      this.usuario = usuario;
    })
  }
}
