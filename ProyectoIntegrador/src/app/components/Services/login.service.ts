import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { map } from 'rxjs/operators';
import { Tipousuario } from '../entidades/tipousuario';
import { UsuarioLogin } from '../entidades/usuariologin';

@Injectable()
export class LoginService {
  private _URL:string = "/api/Usuario";
  usuariologin: UsuarioLogin;
  constructor(private http: HttpClient) {
  }

  cargarTIPOUsuario(){
    let headers = new HttpHeaders().set('Content-Type','application/json');
        console.log(this._URL+'/ListarTipoUsuario' ,{ headers });
        return this.http.get<Tipousuario[]>(this._URL+"/ListarTipoUsuario",{ headers }).pipe(map(res=>{return res;}));
  }

  login(username: string, password: string, tipoUsuario: string) {
    let urlLogin ="/api/usuario/login?";
    urlLogin += "id=" + username + "&";
    urlLogin += "pass=" + password + "&"
    urlLogin += "tipoUsuario=" + tipoUsuario;
    console.log(urlLogin);
    return this.http.get<UsuarioLogin>(urlLogin);
  }
   getUserLoggedIn() {
  	return JSON.parse(localStorage.getItem('currentUser'));
  }
  getIDLoggedIn(){
    return JSON.parse(localStorage.getItem('currentID'));
  }
  
}