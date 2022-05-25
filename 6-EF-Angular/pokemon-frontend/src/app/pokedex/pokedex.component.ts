import { Component, OnInit } from '@angular/core';
import { IPokemon } from '../IPokemon';

@Component({
  selector: 'pokedex',
  templateUrl: './pokedex.component.html',
  styleUrls: ['./pokedex.component.css']
})
export class PokedexComponent implements OnInit {

  pokemon:IPokemon[] =[
    {
      name:"Pikachu",
      level: 5,
      attack: 10,
      defense: 6,
      health: 6
    },
    {
      name:"Mew",
      level: 10,
      attack: 18,
      defense: 18,
      health: 18
    },
    {
      name:"Mudkip",
      level: 7,
      attack: 12,
      defense: 8,
      health: 9
    },
    {
      name:"Sandshrew",
      level: 15,
      attack: 25,
      defense: 13,
      health: 16
    }
  ]

  singlePokemon:IPokemon = {
    name:"",
    level:0,
    attack:0,
    defense:0,
    health:0
  }

  hide:boolean = true;

  buttonText:string = "Show";

  showOrHidePokemonForm():void{
    this.hide = !this.hide
    if(!this.hide){
      this.buttonText = "Hide"
    } else{
      this.buttonText = "Show"
    }

  }

  // We need to catch the emitted event, so we create a method to catch that event
  getPokemonFromNewPokemon($event : any): void{
    // console.log(this.pokemon)
    // console.log($event)

    // this.pokemon.push($event);
    // console.log(this.pokemon)

    this.singlePokemon = $event;
    this.pokemon.push(this.singlePokemon);
  }

  constructor() { }

  ngOnInit(): void {
  }

}
