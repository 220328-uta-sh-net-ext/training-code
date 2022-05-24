import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  constructor() { 
    console.log("Navbar constructed");
  }

  ngOnInit(): void {
    console.log("Navbar initialized");
  }

}
