import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { LoginService } from './login.service';

@Injectable({
  providedIn: 'root'
})
export class SecretGuard implements CanActivate {

  //Create a constructor so we can pull the loginservice
  // Let's pull in the router to navigate back home on unsuccessful attempt
  constructor(private loginService:LoginService, private router:Router){}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    
      // Some condition return true or false
      // True allows you to pass the guard
      if(!!(this.loginService.token)){
      return true;
    } else {
      this.router.navigate(['home'])
      return false;
    }
  }
  
}
