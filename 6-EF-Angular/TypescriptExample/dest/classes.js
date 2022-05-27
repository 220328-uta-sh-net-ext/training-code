"use strict";
// We create classes using the class keyword and an instance of a class is created with the new keyword
// TS supports getter and setter to access and set class members
// Getters and setter are created by using the get and set keywords
class Animal {
    // Constructor
    constructor(name, species) {
        this.name = name;
        this.species = species;
    }
    // Getters and setters
    get getSpecies() {
        return this.species;
    }
    set setSpecies(sp) {
        this.species = sp;
    }
    //Create a Method
    move(feet) {
        console.log(`The animal ${this.name} moved a total of ${feet} feet`);
    }
}
let an = new Animal('Perry', 'Platypus');
an.move(5);
// Instead of using mutators as methods we set them like properities
// A method would like an.setSpecies("Dog")
an.setSpecies = 'Dog';
console.log(an.getSpecies);
//Inheritance is implemented through the extends keyword
class Dog extends Animal {
    bark() {
        console.log('Arf Arf');
    }
}
let m = new Dog('Mya', 'Boxer');
m.bark();
m.move(50);
// We can also create abstract classes
class Car {
    alarm() {
        console.log('BEEEEEEP');
    }
}
class sportCar extends Car {
    drive() {
        console.log('Driving');
    }
}
let sc = new sportCar();
sc.alarm();
sc.drive();
let user1;
user1 = {
    username: 'Leroy',
    password: 'Jenkins',
    login: () => { return true; }
};
let user2;
user2 = {
    username: "Bob",
    password: "TheBuilder",
    phone: 1231231234,
    login: () => { return true; }
};
