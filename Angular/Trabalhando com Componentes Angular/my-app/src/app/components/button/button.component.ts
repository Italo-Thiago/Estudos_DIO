import { Component, Input } from '@angular/core';

@Component({
  selector: 'my-button',
  templateUrl: './button.component.html',
  styleUrls: ['./button.component.css']
})
export class ButtonComponent {
  @Input() label: string = '';
  buttonText: string = 'ACESSAR';
  buttonTexts: string[] = ['Vender', 'Comprar'];
  buttonNumber: number = 1;
  buttonObject = {
    label: 'adicionando ao carrinho',
  }
  getAlert(){
		alert("olá")
	}
}
