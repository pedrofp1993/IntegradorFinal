import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Usuarioreguladorservice } from '../Services/usuarioregulador.services';

@Component({
  selector: 'app-obtenerusuarioregulador',
  templateUrl: './obtenerusuarioregulador.component.html',
  styleUrls: []
})
export class ObtenerusuarioreguladorComponent implements OnInit {
  usuario: any;
  constructor(private _usuarioreguladorService: Usuarioreguladorservice,private router:Router) {
    this.getRegulador(1);
   }

  ngOnInit() {
  }
  getRegulador(id:number){
    this._usuarioreguladorService.obtener(id).subscribe(usuario => {
      console.log(usuario);
      this.usuario = usuario;
    })
  }
}
