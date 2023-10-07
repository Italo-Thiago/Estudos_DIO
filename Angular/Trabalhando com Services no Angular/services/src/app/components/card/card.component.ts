import { Component, OnInit } from '@angular/core';
import { PokemonService } from 'src/app/pokemon.service';

@Component({
  selector: 'app-card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.css']
})
export class CardComponent implements OnInit {
  name: string = "CHARIZARD"
  attributsTypes: string[] = ["Fire","Rock"]

  constructor(
    private service:PokemonService
  ) { }

  ngOnInit(): void {
    this.service.getPokemon("bulbasauro").subscribe
  }
}
