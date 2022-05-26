import { Injectable } from '@angular/core';
// Importing ahead of time so we're just prepped with our imports
import {HttpClient} from '@angular/common/http';
import { Observable, throwError, catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  // We'll use our login service to handle logging in and storing the current user token

  // Let's create a token variable to store our token
  token:string = ""

  // Let's create a basic login method
  login(userName:string, password:string):Observable<any>{
    return this.http.post("https://pokeapi-2203.azurewebsites.net/api/Users/authenticate/", JSON.stringify({userName, password}),
    // We need to add headers to specify content type
    {headers: {'Content-Type':'application/json'}}
    )
    .pipe(
      catchError((e) =>{
        return throwError(e)
      }
    ))
  }

  // Inject HttpClient into our service
  constructor(private http:HttpClient) { }
}
