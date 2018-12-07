import { evento } from "../entidades/evento";
import { objevento } from "../entidades/obevento";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { map } from 'rxjs/operators';
import { eventoaprobar } from "../entidades/eventosxaprobar";
@Injectable()
export class Eventoservice{
    id: number;
    private _URL:string = "/api/Evento";

   
    
    constructor (private http: HttpClient){
        

    }

    registro(evento: evento){

        let body = JSON.stringify(evento);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/RegistroEvento" ,body,{ headers }).pipe(map(res=>{return res;}));

    }
    cargarEventoporaprobar(){
        let headers = new HttpHeaders().set('Content-Type','application/json');
            console.log(this._URL+'/ListarEventos' ,{ headers });
            return this.http.get<evento[]>(this._URL+"/ListarEventos",{ headers }).pipe(map(res=>{return res;}));
      }
    /*actualizar(usuariotienda: Usuariotienda){
        let body = JSON.stringify(usuariotienda);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/ActualizarUsuariosTienda" ,body,{ headers }).pipe(map(res=>{return res;}));
    }
    */
    obtener(id:number){
        let headers = new HttpHeaders().set('Content-Type','application/json');
        console.log(this._URL+'/GetEventoById/'+"?id="+id ,{ headers });
        return this.http.get<eventoaprobar>(this._URL+"/GetEventoById/"+"?id="+id,{ headers });
    }
    obtenerxaprobar(){
        let headers = new HttpHeaders().set('Content-Type','application/json');
            console.log(this._URL+'/ListarEventosPorAprobar' ,{ headers });
            return this.http.get<eventoaprobar[]>(this._URL+"/ListarEventosPorAprobar",{ headers }).pipe(map(res=>{return res;}));
    }
    calificarevento(id:number){
        let headers = new HttpHeaders().set('Content-Type','application/json');
            console.log(this._URL+'/ListarEventosAprobados/'+"?id="+id ,{ headers });
            return this.http.get<eventoaprobar>(this._URL+"/ListarEventosAprobados/"+"?id="+id,{ headers }).pipe(map(res=>{return res;}));
    }
    actualizarEventoaaprobado(evento:eventoaprobar){
        let body = JSON.stringify(evento);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/EventoAprobado" ,body,{ headers }).pipe(map(res=>{return res;}));
    }
    actualizarEventoadesaprobado(evento:eventoaprobar){
        let body = JSON.stringify(evento);
        let headers = new HttpHeaders().set('Content-Type','application/json');
        return this.http.post(this._URL+"/ActualizarDesaprobado" ,body,{ headers }).pipe(map(res=>{return res;}));
    }
}