import { ComponentFixture, TestBed } from '@angular/core/testing';

// Import Router testing module and HttpClient testing Module to test build
import { RouterTestingModule } from '@angular/router/testing'
import { HttpClientTestingModule } from '@angular/common/http/testing'

import { PokedexComponent } from './pokedex.component';

// Importing in for additional testing
import {NewPokemonComponent} from '../new-pokemon/new-pokemon.component'
import {PokemonService} from '../pokemon.service'
import {Subject} from 'rxjs'
import {IPokemon} from '../IPokemon'
import { By } from '@angular/platform-browser';

// Create a mocking class for Pokemon Service
class MockPokemonService{

  subject : Subject<IPokemon[]> = new Subject<IPokemon[]>();

  getPokemon(){
    return [
      {
        name: "",
        level: 0,
        attack: 0,
        defense: 0,
        health: 0
      }
    ]
  }

  addPokemon(poke:IPokemon){
    return {
      name: "",
      level: 0,
      attack: 0,
      defense: 0,
      health: 0
    }
  }

}

describe('PokedexComponent', () => {
  let component: PokedexComponent;
  let fixture: ComponentFixture<PokedexComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PokedexComponent , NewPokemonComponent ],
      // Create imports to import modules
      imports : [
        RouterTestingModule,
        HttpClientTestingModule
      ],
      // Use Providers to reroute services calls to our mocking service
      providers : [{provide: PokemonService, useClass:MockPokemonService}]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PokedexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  // Let's create a test using our mocked service
  it('should call the pokemonService on init for getPokemon()', () =>{
    // Use injector to get pokemon service
    let service = fixture.debugElement.injector.get(PokemonService);

    // Let's create a spy to spy on our service
    // This will tell if a method is being called
    let serviceSpy = spyOn(service, 'getPokemon').and.callThrough();

    // Force component to run ngOnInit
    component.ngOnInit();

    // Expect our service spy to see get pokemon being called
    expect(serviceSpy).toHaveBeenCalled();
  })

  // Create a test for the addPokemon method where we send a pokemon object from new pokemon
  it('should call addPokemon() from pokemonService when it receives a pokemon', () =>{
    // Basically the same test as before so far
    let service = fixture.debugElement.injector.get(PokemonService);
    let serviceSpy = spyOn(service, 'addPokemon').and.callThrough();

    // Pull the new pokemon tag and store it so we can emit info from it
    const newPokemon = fixture.debugElement.query(By.directive(NewPokemonComponent));

    // Emit send pokemon event and the event object
    newPokemon.triggerEventHandler('sendPokemon', {
      name: "",
      level: 0,
      attack: 0,
      defense: 0,
      health: 0,
      abilities:[]
    });

    // Look for changes
    fixture.detectChanges();

    // Check the spy
    expect(serviceSpy).toHaveBeenCalled();
  })

});
