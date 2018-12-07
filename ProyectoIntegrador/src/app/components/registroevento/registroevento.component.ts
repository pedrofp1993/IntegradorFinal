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
  hoy:Date = new Date();
  dia:string[] ;
  diafin:string[];
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
    this.dia = this.evento.FECHA_INIC.split("-");
    this.diafin = this.evento.FEHA_FIN.split("-");
    console.log(this.evento);
    if(this.formulario.valid && parseInt(this.dia[2]) >= this.hoy.getDay() && parseInt(this.dia[1]) >= this.hoy.getMonth() && parseInt(this.dia[0]) >= this.hoy.getFullYear()
        && parseInt(this.diafin[2]) >= parseInt(this.dia[2]) && parseInt(this.diafin[1]) >= parseInt(this.dia[1]) && parseInt(this.diafin[0]) >= parseInt(this.dia[0])
       // ||  parseInt(this.dia[2]) >= this.hoy.getDay() && parseInt(this.dia[1]) <= this.hoy.getMonth() && parseInt(this.dia[0]) > this.hoy.getFullYear()     
       // && parseInt(this.diafin[2]) >= parseInt(this.dia[2]) && parseInt(this.diafin[1]) >= parseInt(this.dia[1]) && parseInt(this.diafin[0]) > parseInt(this.dia[0])
       ){
      this.bulean = true;
    this._eventoService.registro(this.evento)
      .subscribe(data => {
        console.log(this.dia[2])
        console.log(this.dia[1])
        console.log(this.dia[0])
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));
        window.alert("Se registro con exito el evento");
        this._router.navigate(['/home']);
      
    } else {
      window.alert("Ocurrio un error por favor revise los campos nuevamente");
      console.log("ERROR");
    }
  }

  ngOnInit() {
    console.log(this.hoy);
  }

}
