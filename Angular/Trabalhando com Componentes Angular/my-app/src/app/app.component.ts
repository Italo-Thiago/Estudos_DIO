import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'my-app';
  buttonLabel: string = 'CARRINHO';
  buttonSecond: string = 'ADICIONAR A FAVORITO';
}
