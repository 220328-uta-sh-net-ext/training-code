import { Component, OnInit } from '@angular/core';
import { IPokemon } from '../IPokemon';
import { PokemonService } from '../pokemon.service';

@Component({
  selector: 'pokedex',
  templateUrl: './pokedex.component.html',
  styleUrls: ['./pokedex.component.css']
})
export class PokedexComponent implements OnInit {

  pokemon:IPokemon[] =[]

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
    // this.pokemon.push(this.singlePokemon);
    this.addPokemon(this.singlePokemon);
  }

  // Utilizing the addPokemon method from the service to add to our "database"
  addPokemon(poke:IPokemon):void{
    this.pokemon = this.pokemonService.addPokemon(poke)
  }

  // We use constructor dependency injection to pull the pokemon serve
  constructor(private pokemonService: PokemonService) { }

  ngOnInit(): void {
    // On initialization we use the getPokemon method from the service
    // To populate our array with the data pulled from the service
    this.pokemon = this.pokemonService.getPokemon()
  }
  

}

