import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { NavbarComponent } from './navbar/navbar.component';
import { PokedexComponent } from './pokedex/pokedex.component';
import { PokemonComponent } from './pokemon/pokemon.component';
import { NewPokemonComponent } from './new-pokemon/new-pokemon.component';
import { FormsModule } from '@angular/forms';
import { SquarePipe } from './square.pipe';
import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { SecretComponent } from './secret/secret.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    NavbarComponent,
    PokedexComponent,
    PokemonComponent,
    NewPokemonComponent,
    SquarePipe,
    LoginComponent,
    SecretComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    // Add in HttpClient Module
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
