import{ Usuariojugador } from "../entidades/usuariojugador";
import { Injectable } from "@angular/core";
import { Http } from "@angular/http";
import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Observable } from "rxjs";
import { map } from 'rxjs/operators';

@Injectable()
export class Usuariojugadorservice{

    private _URL:string = "/api/Usuario";

   
    
    constructor (private http: HttpClient){
        

    }

    registro(usuariojugador: Usuariojugador){

        let body = JSON.stringify(usuariojugador);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/RegistroUsuarioJugador" ,body,{ headers }).pipe(map(res=>{return res;}));

    }
    actualizar(usuariojugador: Usuariojugador){
        let body = JSON.stringify(usuariojugador);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/ActualizarUsuariosJugadores" ,body,{ headers }).pipe(map(res=>{return res;}));
    }

    obtener(COD_JUGADOR:number){
        let headers = new HttpHeaders().set('Content-Type','application/json');
        console.log(this._URL+'/GetUsuarioJugadorById/'+"?id="+COD_JUGADOR ,{ headers });
        return this.http.get(this._URL+"/GetUsuarioJugadorById/"+"?id="+COD_JUGADOR,{ headers });
    }
}