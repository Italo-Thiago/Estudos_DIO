import { Component } from '@angular/core';

@Component({
  selector: 'app-comp-atributos',
  templateUrl: './comp-atributos.component.html',
  styleUrls: ['./comp-atributos.component.css']
})
export class CompAtributosComponent {
  estilo: string = "disable";
  corFundo: string = "red";
  corDaFonte: string = "#696969";
  itens: string = "";
  lista:string[] = [];
  isEnableBlock: boolean = true;

  adicionarLista() {
    this.lista.push(this.itens);
  }

  trocar(){
    if(this.estilo === "disable"){
      this.estilo = "enable";
    } else {
      this.estilo = "disable";
    }
  }
}
