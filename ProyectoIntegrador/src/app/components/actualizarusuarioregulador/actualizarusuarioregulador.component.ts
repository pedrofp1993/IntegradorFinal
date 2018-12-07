import { Component, OnInit } from '@angular/core';
import { Usuarioregulador } from '../entidades/usuarioregulador';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Usuarioreguladorservice } from '../Services/usuarioregulador.services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-actualizarusuarioregulador',
  templateUrl: './actualizarusuarioregulador.component.html',
  styleUrls: []
})
export class ActualizarusuarioreguladorComponent implements OnInit {
  formulario: FormGroup;
  onSubmit: boolean = false;
  usuario: Usuarioregulador;
  constructor(private _usuarioreguladorService: Usuarioreguladorservice,
    private _router:Router) { 
      this.formulario = new FormGroup({
      'COD_REG': new FormControl('', [Validators.required]),  
      'NIVEL': new FormControl('', [Validators.required]),  
      'CATEGORIA': new FormControl('', [Validators.required]),
    }); 
  }
  actualizar(){
    this.onSubmit = true;
    console.log(this.formulario);
    this.usuario = {
      COD_REG: 1,
      NOM_REG: "ww",
      APE_REG: "ww",
      CORREO: "ww",
      CATEGORIA: 1,
      NIVEL: 1,
      COD_ID: "ww",
      CONTRA_USU_REGUL: "1"
    }

    console.log(this.usuario);

    this._usuarioreguladorService.actualizar(this.usuario)
      .subscribe(data => {
        console.log(data);
        //this.router.navigate(['/heroe',data['name']])
      },
        error => console.error(error));

  }

  ngOnInit() {
  }

}
