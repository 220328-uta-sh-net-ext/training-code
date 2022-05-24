function getPokemon(){
    console.log("get pokemon started"); 
    //logic to get pokemon from the api : https://pokeapi.co/
    // empty object to store fetched pokemons
    let pokemon={};
    
    // to grab the textbox value
    let pokeName = document.getElementById("pokemonName").value;
    
    //1. create an obj to call the server
    let request=new XMLHttpRequest();
    //2. Send request to the server
    request.open("GET",`https://localhost:7185/api/Pokemon/name?name=${pokeName}`,true);
    //3. send the request to server
    request.send();
    //4. process the response
    /*
    AJAX have 5 states of the request when it is sent to the server it is called readyStateChange (event)
        0 - uninitialized
        1 - loading (server connection has been established)
        2 - loaded (request has been process and response is made)
        3 - Interactive (response is being sent to browser)
        4 - complete
    */
   request.onreadystatechange = function(){
            if(this.readyState==4 && (this.status > 199 && this.status<300)){
                pokemon = JSON.parse(request.responseText)// convert json string to javascript object
                debugger;
                console.log(pokemon);
                displayPokemon(pokemon);
            }
   }
 console.log("get pokemon finished"); 
}

// this function will disply the pokemon to the page
function displayPokemon(poke){
    //document.getElementById("pokeImage").setAttribute("src", poke.sprites.front_default);

     let list = document.getElementById("abilities");
    list.innerHTML="";
    debugger;
    poke.abilities.forEach((item) => {
        console.log(item);
        let li = document.createElement("li");
        li.innerText = item.name;        
        list.appendChild(li);
      });
   
}


function fetchPokemon(){
    let name = document.getElementById("pokemonName").value;

    // fetch api gives a promise
    // A promise will either execute the request successfulyy or failure
    fetch(`https://pokeapi.co/api/v2/pokemon/${name}`)
    .then(result=>result.json())
    .then(pokemon=>{
        let caption=document.createElement("caption");
        document.getElementById("pokeImage").setAttribute("src", pokemon.sprites.front_default);
        let results=document.querySelectorAll("#pokeResults caption").forEach((element)=>element.remove());
        caption.innerHTML=pokemon.name;
        document.getElementById("pokeResults").appendChild(caption);
    })
}
