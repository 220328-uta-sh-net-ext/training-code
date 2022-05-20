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
    debugger;
    var name=prompt('Please enter your name ');
    greeting(name);
}