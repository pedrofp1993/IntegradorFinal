import { Usuarioregulador } from "../entidades/usuarioregulador";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from 'rxjs/operators';
@Injectable()
export class Usuarioreguladorservice{

    private _URL:string = "/api/Usuario";

   
    
    constructor (private http: HttpClient){
        

    }

    registro(usuarioregulador: Usuarioregulador){

        let body = JSON.stringify(usuarioregulador);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/RegistroUsuarioRegulador" ,body,{ headers }).pipe(map(res=>{return res;}));

    }
    actualizar(usuarioregulador: Usuarioregulador){
        let body = JSON.stringify(usuarioregulador);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/ActualizarUsuariosReguladores" ,body,{ headers }).pipe(map(res=>{return res;}));
    }

    obtener(COD_REG:number){
        let headers = new HttpHeaders().set('Content-Type','application/json');
        console.log(this._URL+'/GetUsuarioReguladorById/'+"?id="+COD_REG ,{ headers });
        return this.http.get(this._URL+"/GetUsuarioReguladorById/"+"?id="+COD_REG,{ headers });
    }
}