import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Eventoservice } from '../Services/eventoservices.service';
import{ evento } from "../entidades/evento";
import { Router } from "@angular/router";
@Component({
  selector: 'app-registroevento',
  templateUrl: './registroevento.component.html',
  styleUrls: []
})
export class RegistroeventoComponent implements OnInit {

  formulario: FormGroup;
  onSubmit: boolean = false;
  evento: evento;
  bulean: boolean = null;
  constructor(private _eventoService: Eventoservice,
              private _router:Router) { 
                this.formulario = new FormGroup({
                  'NOMBRE_EVEN': new FormControl('', [Validators.required]),
                  'DESCRIPCION': new FormControl('', [Validators.required]),
                  'INFO': new FormControl('', [Validators.required]),
                  'FECHA_INIC': new FormControl('', [Validators.required]),
                  'FEHA_FIN': new FormControl('', [Validators.required]),
                  'CIUDAD': new FormControl('', [Validators.required]),
                  'DIRECCION': new FormControl('', [Validators.required]),
                  'REFRENCIA': new FormControl('', [Validators.required]),
                  'CANTIDAD': new FormControl('', [Validators.required]),
                  'PRECIO': new FormControl('', [Validators.required])
                });
  }

  registrar(){
    console.log(JSON.parse(localStorage.getItem('currentID')));
    this.bulean = false;
    this.onSubmit = true;
    console.log(this.formulario);
    this.evento = {
      
      NOMBRE_EVEN: this.formulario.controls['NOMBRE_EVEN'].value,
      DESCRIPCION: this.formulario.controls['DESCRIPCION'].value,
      INFO: this.formulario.controls['INFO'].value,
      FECHA_INIC: this.formulario.controls['FECHA_INIC'].value,
      FEHA_FIN: this.formulario.controls['FEHA_FIN'].value,
      CIUDAD: this.formulario.controls['CIUDAD'].value,
      DIRECCION: this.formulario.controls['DIRECCION'].value,
      REFRENCIA: this.formulario.controls['REFRENCIA'].value,
      CANTIDAD: this.formulario.controls['CANTIDAD'].value,
      PRECIO: this.formulario.controls['PRECIO'].value,
      ID_USU_TIENDA: JSON.parse(localStorage.getItem('currentID')),
    }

    console.log(this.evento);
    if(this.formulario.valid){
      this.bulean = true;
    this._eventoService.registro(this.evento)
      .subscribe(data => {
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));
        window.alert("Se registro con exito el evento");
        this._router.navigate(['/home']);
      
    } else {
      console.log("ERROR");
    }
  }

  ngOnInit() {
  }

}
