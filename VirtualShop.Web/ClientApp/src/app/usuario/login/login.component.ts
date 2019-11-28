import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, ActivatedRoute } from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls:["./login.component.css"]
})

export class LoginComponent implements OnInit {
    

  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activateRouter: ActivatedRoute, private usuarioServico: UsuarioServico) {

  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activateRouter.snapshot.queryParams['returnUrl'];
  }

  entrar() {

    this.usuarioServico.verificarUsuario(this.usuario)
      .subscribe(data => {

      },
        err => {

        }
     );

    //if (this.usuario.email == "teste@teste.com" && this.usuario.senha == "abc123") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);} 
  }
}
