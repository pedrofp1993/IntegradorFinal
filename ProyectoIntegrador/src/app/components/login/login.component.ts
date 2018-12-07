import { Component, OnInit } from '@angular/core';
import { LoginService } from '../Services/login.service';
import { Router } from '@angular/router';
import { Tipousuario } from '../entidades/tipousuario';
import { UsuarioLogin } from '../entidades/usuariologin';
import { NavbarComponent } from '../navbar/navbar.component';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {
  usuario : string ="";
  password : string ="";
  tipoUsuario: string = "";
  tipo: Tipousuario[];
  usuariologin: UsuarioLogin;
  navbar: NavbarComponent;
  constructor(private loginService:LoginService,private _router:Router) { 
  
  }

  ngOnInit() {
    this.obtener();
  }
  obtener(){
    this.loginService.cargarTIPOUsuario().subscribe(tipo => {
      console.log(this.tipo);
      this.tipo=tipo;
      
    })
  }
  loggin(){
    console.log("usuario",this.usuario,"pwd",this.password,"tipo",this.tipoUsuario);
    this.loginService.login(this.usuario,this.password,this.tipoUsuario)
      .subscribe(usuariologin=>{
        
        this.usuariologin = usuariologin;
        if(this.usuariologin.UsuarioPermitido == true){
          
          console.log(this.usuariologin.UsuarioPerfil);
          
          localStorage.setItem('currentUser', JSON.stringify(this.usuariologin.UsuarioPerfil));
          localStorage.setItem("currentID", JSON.stringify(this.usuariologin.UsuarioNombre));
          console.log(JSON.parse(localStorage.getItem('currentUser')));
          
          window.alert("LOGIN");
          this._router.navigate(['/home']);
        } else {
          window.alert("Credenciales invalidas");
        }
      })
  }
  
}
