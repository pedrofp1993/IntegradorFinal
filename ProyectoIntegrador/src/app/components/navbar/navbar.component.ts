import { Component, OnInit } from '@angular/core';
import { UsuarioLogin } from '../entidades/usuariologin';
import { LoginService } from '../Services/login.service';
import { Router } from '@angular/router';
import { LoginComponent } from '../login/login.component';
@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styles: []
})
export class NavbarComponent implements OnInit {
  nombre: String;
  UsuarioLogin:UsuarioLogin;
  logincomponent: LoginComponent;
  usuariologin:String;
  constructor(private _loginservice:LoginService,private _router:Router) { 
  }

  ngOnInit() {
    localStorage.setItem('currentUser', JSON.stringify(""));
    
  }
  
  
  cerrarSesion(){
    localStorage.setItem('currentUser',JSON.stringify(""));
    window.alert("Sesion Cerrada");
    this._router.navigate(['/login']);
  }
  
  isTienda(){
    if(this._loginservice.getUserLoggedIn() == "TIENDA"){
      this.obtenerNombre();
      return true; 
      
    }
    else
      return false; 
  }
  isVacio(){
    if(this._loginservice.getUserLoggedIn() == ""){

      return true; 
    }
    else
      return false; 
  }
  isRegulador(){
    if(this._loginservice.getUserLoggedIn() == "REGULADOR"){
      this.obtenerNombre();
      return true; 
    }
    else
      return false; 
  }
  isJugador(){
    if(this._loginservice.getUserLoggedIn() == "JUGADOR"){
      this.obtenerNombre();
      return true; 
    }
    else
      return false; 
  }
  obtenerNombre(){
    
    this.nombre = this._loginservice.getIDLoggedIn();
    console.log(this.nombre);
  }

}
