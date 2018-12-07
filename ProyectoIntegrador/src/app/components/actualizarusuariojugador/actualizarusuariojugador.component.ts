import { Component, OnInit } from '@angular/core';
import { Usuariojugador } from '../entidades/usuariojugador';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Usuariojugadorservice } from '../Services/usuariojugador.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-actualizarusuariojugador',
  templateUrl: './actualizarusuariojugador.component.html',
  styleUrls: []
})
export class ActualizarusuariojugadorComponent implements OnInit {

  formulario: FormGroup;
  onSubmit: boolean = false;
  usuario: Usuariojugador;
  constructor(private _usuariojugadorService: Usuariojugadorservice,
              private _router:Router) { 
                this.formulario = new FormGroup({
                  'COD_JUGADOR': new FormControl('', [Validators.required]),  
                  'CORREO_ELECTRONICO': new FormControl('', [Validators.required]),  
                  'DIRECCION': new FormControl('', [Validators.required]),
                  'CIUDAD': new FormControl('', [Validators.required]),
                });
  }

  actualizar(){
    this.onSubmit = true;
    console.log(this.formulario);
    this.usuario = {
      COD_JUGADOR: this.formulario.controls['COD_JUGADOR'].value,
      NOM_JUGADOR: "ww",
      APELLIDO_JUGADOR: "ww",
      CORREO_ELECTRONICO: this.formulario.controls['CORREO_ELECTRONICO'].value,
      ID_USUARIO_JUG:"ww",
      CONTRASEÑA:"ww",
      DIRECCION: this.formulario.controls['DIRECCION'].value,
      CIUDAD: this.formulario.controls['CIUDAD'].value,
      DNI:"11111111",
      FECHA_NACIMIENTO:"22"
    }

    console.log(this.usuario);

    this._usuariojugadorService.actualizar(this.usuario)
      .subscribe(data => {
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));

  }

  ngOnInit() {
  }

}
