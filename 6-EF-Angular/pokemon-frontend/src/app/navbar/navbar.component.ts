import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  // Create method to navigate to the login page
  navigateLogin(){
    this.router.navigate(['login']);
  }

  // Inject our router in the constructor to navigate
  constructor(private router:Router) { 
    console.log("Navbar constructed");
  }

  ngOnInit(): void {
    console.log("Navbar initialized");
  }

}
