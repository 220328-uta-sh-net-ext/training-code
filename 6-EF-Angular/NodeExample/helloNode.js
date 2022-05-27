console.log('Hello Node');

// ES6 gives us the ability to create what's known as a module
// A module is a piece of reusable code
// Specify it with imports and exports

function greeting(name){
    return `Hello my name is ${name}`
}

module.exports = greeting;