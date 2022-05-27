import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { HomePageComponent } from "./home-page/home-page.component";
import { RouterModule } from "@angular/router";
import { PokedexComponent } from "./pokedex/pokedex.component";
import { LoginComponent } from "./login/login.component";
import { SecretComponent } from "./secret/secret.component";
import { SecretGuard } from "./secret.guard";

// Let's declare some routes for routing
const routes = [
    {path: '', redirectTo : '/home', pathMatch:'full'},
    {path: 'home', component: HomePageComponent},
    {path : 'pokedex', component: PokedexComponent},
    //Create new path for login
    {path: 'login', component: LoginComponent},
    // Add route with route guard for secret
    {path: 'secret', component:SecretComponent, canActivate:[SecretGuard]}
]

//Start Building NgModule to create routing
@NgModule({
    declarations: [],
    imports: [
        CommonModule,
        RouterModule.forRoot(routes)
    ],
    exports: [RouterModule]
})


// This is how we're going to call the module later
export class AppRoutingModule{}