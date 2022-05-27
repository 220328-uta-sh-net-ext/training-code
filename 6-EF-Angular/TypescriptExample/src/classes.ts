// We create classes using the class keyword and an instance of a class is created with the new keyword
// TS supports getter and setter to access and set class members
// Getters and setter are created by using the get and set keywords
class Animal{
    // fields
    readonly name: string;
    private species: string;

    // Constructor
    constructor(name:string, species:string){
        this.name = name;
        this.species = species;
    }

    // Getters and setters

    get getSpecies(): string{
        return this.species;
    }

    set setSpecies(sp: string){
        this.species = sp;
    }

    //Create a Method
    move(feet:number): void{
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

class Dog extends Animal{
    bark():void{
        console.log('Arf Arf');
    }
}

let m = new Dog('Mya', 'Boxer');

m.bark();
m.move(50);

// We can also create abstract classes
abstract class Car{
    abstract drive():void;

    alarm():void{
        console.log('BEEEEEEP')
    }
}

class sportCar extends Car{
    drive(): void {
        console.log('Driving');
    }
}

let sc = new sportCar();

sc.alarm();
sc.drive();

// Interfaces allow us to create contracts that other classes or objects must implement
interface User{
    username: string;
    password: string;
    phone?: number;
    login() : boolean;
}

let user1:User;

user1 = {
    username: 'Leroy',
    password: 'Jenkins',
    login: () => {return true}
}

let user2:User;

user2 = {
    username: "Bob",
    password: "TheBuilder",
    phone:1231231234,
    login: ()=>{return true}
}