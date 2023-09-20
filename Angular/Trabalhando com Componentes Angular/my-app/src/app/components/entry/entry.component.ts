import { Component } from '@angular/core';

@Component({
  selector: 'app-entry-data',
  templateUrl: './entry.component.html',
  styleUrls: ['./entry.component.css']
})
export class EntryComponent {
  placeholder: string = "email"
  placepass: string = "senha"
  color:string = "red"
}
