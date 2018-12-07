import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Usuarioreguladorservice } from '../Services/usuarioregulador.services';
import{ Usuarioregulador } from "../entidades/usuarioregulador";
import { Router } from "@angular/router";
@Component({
  selector: 'app-registrousuarioregulador',
  templateUrl: './registrousuarioregulador.component.html',
  styleUrls: []
})
export class RegistrousuarioreguladorComponent implements OnInit {
  formulario: FormGroup;
  onSubmit: boolean = false;
  usuario: Usuarioregulador;
  bulean: boolean = null;
  constructor(private _usuarioreguladorService: Usuarioreguladorservice,
    private _router:Router) { 
        this.formulario = new FormGroup({
        'NOM_REG': new FormControl('', [Validators.required]),
        'APE_REG': new FormControl('', [Validators.required]),
        'CORREO': new FormControl('', [Validators.required, Validators.pattern("[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$")]),
        'NIVEL': new FormControl('', [Validators.required]),
        'CATEGORIA': new FormControl('', [Validators.required]),
        'COD_ID': new FormControl('', [Validators.required]),
        'ID_USU_REGUL': new FormControl('', [Validators.required]),
        'CONTRA_USU_REGUL': new FormControl('', [Validators.required]),
      });
    }
    registrar(){
      this.bulean = false;
      this.onSubmit = true;
      console.log(this.formulario);
      this.usuario = {
        COD_REG: 0,
        NOM_REG: this.formulario.controls['NOM_REG'].value,
        APE_REG: this.formulario.controls['APE_REG'].value,
        CORREO: this.formulario.controls['CORREO'].value,
        NIVEL: this.formulario.controls['NIVEL'].value,
        CATEGORIA: this.formulario.controls['CATEGORIA'].value,
        COD_ID: this.formulario.controls['COD_ID'].value,
        CONTRA_USU_REGUL: this.formulario.controls['CONTRA_USU_REGUL'].value
      }
  
      console.log(this.usuario);
      if(this.formulario.valid){
        this.bulean = true;
      this._usuarioreguladorService.registro(this.usuario)
        .subscribe(data => {
          console.log(data);
          //this.router.navigate(['/heroe',data['name']])
        },
          error => console.error(error));
          setTimeout(function(){
            this._router.navigate(['/home']);
          }.bind(this),6000);
      }else {
        console.log("ERROR");
      }
    }
  ngOnInit() {
  }

}
