import { Usuariotienda } from "../entidades/usuariotienda";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from 'rxjs/operators';
@Injectable()
export class Usuariotiendaservice{

    private _URL:string = "/api/Usuario";

   
    
    constructor (private http: HttpClient){
        

    }

    registro(usuariotienda: Usuariotienda){

        let body = JSON.stringify(usuariotienda);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/RegistroUsuarioTienda" ,body,{ headers }).pipe(map(res=>{return res;}));

    }
    actualizar(usuariotienda: Usuariotienda){
        let body = JSON.stringify(usuariotienda);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/ActualizarUsuariosTienda" ,body,{ headers }).pipe(map(res=>{return res;}));
    }

    obtener(COD_USU_TIENDA:number){
        let headers = new HttpHeaders().set('Content-Type','application/json');
        console.log(this._URL+'/GetUsuarioTiendaById/'+"?id="+COD_USU_TIENDA ,{ headers });
        return this.http.get(this._URL+"/GetUsuarioTiendaById/"+"?id="+COD_USU_TIENDA,{ headers });
    }
}