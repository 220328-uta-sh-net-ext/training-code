//window.onload = BasicFunction();
function basicFunction(){
    console.log("Calling named function"); 
};// named function*/

// anonymous function - single use only and they are created and called just once 
var anonymous= function(){
    console.log("Calling anonymous function"); 
};

//Arrow Notation
var arrowFunction= ()=>console.log("calling arrow function");

//Arrow function, IIFE
(()=>console.log('IIFE function called'))(); 

//Prototype function - used for inheritance via functions, its like object
function prototypeFunction(){
    prototypeFunction.prototype.Name="something";
    prototypeFunction.prototype.Id="Some Id";
    console.log(prototypeFunction.prototype);
}

function greeting(name){
    console.log("Hello "+name);
}

function Input(greeting){
    debugger; // to enable debugging 
    var name=prompt('Please enter your name ');
    greeting(name);
}


function CreateObjects(){
    let dog = {
        color:"Beige",
        size : "40",
        sound: ()=>console.log("Woof woof"),
        details: function(){
            console.log("This dog is of "+this.color +" color and is "+this.size+ " lbs")
        }
    }
    console.log(dog);
    dog.size=100;
    dog.sound();
    dog.details();
}