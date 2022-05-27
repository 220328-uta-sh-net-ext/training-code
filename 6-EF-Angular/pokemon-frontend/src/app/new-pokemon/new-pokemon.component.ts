import { Component, OnInit, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'new-pokemon',
  templateUrl: './new-pokemon.component.html',
  styleUrls: ['./new-pokemon.component.css']
})
export class NewPokemonComponent implements OnInit {

  // To send data from the new pokemon component to the pokedex we need
  // to use @Output and create a new event emitter

  @Output() sendPokemon = new EventEmitter();

  // We need to create some variable to hold user input
  pokemonName:string = "";
  pokemonLevel:number = 0;
  pokemonAttack:number = 0;
  pokemonDefense:number = 0;
  pokemonHealth:number = 0;

  onSubmit(): void{
    console.log("called: ", this.pokemonName);
    const pokemon = {
      name:this.pokemonName,
      level:this.pokemonLevel,
      attack:this.pokemonAttack,
      defense:this.pokemonDefense,
      health:this.pokemonHealth
    }

    this.sendPokemon.emit(pokemon);

    this.pokemonName = "";
    this.pokemonLevel = 0;
    this.pokemonAttack = 0;
    this.pokemonDefense = 0;
    this.pokemonHealth = 0;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
