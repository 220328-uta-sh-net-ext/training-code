import { Component, Input, OnInit } from '@angular/core';
import { IPokemon } from '../IPokemon';

@Component({
  selector: 'pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.css']
})
export class PokemonComponent implements OnInit {

  @Input() poke:IPokemon = {
    name:"",
    level:0,
    attack:0,
    defense:0,
    health:0
  }

  selected:boolean = false;

  selectPokemon():void{
    this.selected = !this.selected;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
