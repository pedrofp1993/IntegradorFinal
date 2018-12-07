import { Component, OnInit } from '@angular/core';
import { Usuariotienda } from '../entidades/usuariotienda';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Usuariotiendaservice } from '../Services/usuariotienda.service';
import { Router } from '@angular/router';
@Component({
  selector: 'app-actualizarusuariotienda',
  templateUrl: './actualizarusuariotienda.component.html',
  styleUrls: []
})
export class ActualizarusuariotiendaComponent implements OnInit {
  formulario: FormGroup;
  onSubmit: boolean = false;
  usuario: Usuariotienda;
  constructor(private _usuariotiendaService: Usuariotiendaservice,
    private _router:Router) { 
      this.formulario = new FormGroup({
        'COD_USU_TIENDA': new FormControl('', [Validators.required]),  
        'REP_LEGAL': new FormControl('', [Validators.required]),  
        'CORREO_UST': new FormControl('', [Validators.required]),
        'DIRECCION': new FormControl('', [Validators.required]),
        'TELEFONO': new FormControl('', [Validators.required]),
      }); 
    }
    actualizar(){
      this.onSubmit = true;
      console.log(this.formulario);
      this.usuario = {
        COD_USU_TIENDA: 1,
        RAZON_SOCIAL: "ww",
        REP_LEGAL: "ww",
        CORREO_UST: "ww",
        DIRECCION: "ww",
        TELEFONO: "ww",
        FECHA_CONSTITU: "ww",
        RUC: "ww211111",
        ID_USU_TIENDA: "ww",
        CONTRA_USU_TIENDA: "ww",
      }
  
      console.log(this.usuario);
  
      this._usuariotiendaService.actualizar(this.usuario)
        .subscribe(data => {
          console.log(data);
          //this.router.navigate(['/heroe',data['name']])
        },
          error => console.error(error));
  
    }
  
  ngOnInit() {
  }

}
