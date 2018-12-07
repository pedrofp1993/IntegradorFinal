import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Usuariotiendaservice } from '../Services/usuariotienda.service';
import{ Usuariotienda } from "../entidades/usuariotienda";
import { Router } from "@angular/router";
@Component({
  selector: 'app-registrousuariotienda',
  templateUrl: './registrousuariotienda.component.html',
  styleUrls: []
})
export class RegistrousuariotiendaComponent implements OnInit {
  formulario: FormGroup;
  onSubmit: boolean = false;
  bulean: boolean = null;
  usuario: Usuariotienda;
  constructor(private _usuariotiendaService: Usuariotiendaservice,
    private _router:Router) {
        this.formulario = new FormGroup({
        'RAZON_SOCIAL': new FormControl('', [Validators.required]),
        'REP_LEGAL': new FormControl('', [Validators.required]),
        'CORREO_UST': new FormControl('', [Validators.required, Validators.pattern("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$")]),
        'DIRECCION': new FormControl('', [Validators.required]),
        'TELEFONO': new FormControl('', [Validators.required]),
        'FECHA_CONSTITU': new FormControl('', [Validators.required]),
        'RUC': new FormControl('', [Validators.required,Validators.pattern("[0-9]{8}$")]),
        'ID_USU_TIENDA': new FormControl('', [Validators.required]),
        'CONTRA_USU_TIENDA': new FormControl('', [Validators.required]),
        
      });
     }
     registrar(){
      this.bulean = false;
      this.onSubmit = true;
      console.log(this.formulario);
      this.usuario = {
        COD_USU_TIENDA: 0,
        RAZON_SOCIAL: this.formulario.controls['RAZON_SOCIAL'].value,
        REP_LEGAL: this.formulario.controls['REP_LEGAL'].value,
        CORREO_UST: this.formulario.controls['CORREO_UST'].value,
        DIRECCION: this.formulario.controls['DIRECCION'].value,
        TELEFONO: this.formulario.controls['TELEFONO'].value,
        FECHA_CONSTITU: this.formulario.controls['FECHA_CONSTITU'].value,
        RUC: this.formulario.controls['RUC'].value,
        ID_USU_TIENDA: this.formulario.controls['ID_USU_TIENDA'].value,
        CONTRA_USU_TIENDA: this.formulario.controls['CONTRA_USU_TIENDA'].value
      }
  
      console.log(this.usuario);
      if(this.formulario.valid){
        this.bulean = true;
        this._usuariotiendaService.registro(this.usuario)
        .subscribe(data => {
          console.log(data);
          //this.router.navigate(['/heroe',data['name']])
        },error => console.error(error));
          setTimeout(function(){
            this._router.navigate(['/home']);
          }.bind(this),6000);
          
      } else {
        console.log("ERROR");
      }
    }
    
  ngOnInit() {
  }

}
