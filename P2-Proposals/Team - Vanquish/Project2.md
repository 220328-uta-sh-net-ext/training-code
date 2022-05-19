# Poke-Pictionary
## Vanquish
    - Osman Elmahadi
    - Sean Letts
    - Randy Robinson
    - Steve Burgos
## Project Synopsis

A user will be able to log in to our website. From there, they can either look at their past drawings, look at other people's drawings, organized by
either time of posting (by most recent) or by most popular, able to rate each other's drawings. If they desire, the user can also play a game.
In single player, the user will recieve a random pokemon. From there, they attempt to draw said pokemon in the canvas screen. When done, their drawing
is put side by side with the original art. The user can then download it, upload it and save it, or delete it. The user can attempt this with a hint,
the pokemon sprite next to their drawing, or blind. A 1 on 1 feature could be added where a person attempts to draw a pokemon within a set period of time.
Once done, the other person gets the image and can try and guess what pokemon it is that the other person drew up. 

## Tech Stack (feel free to add more)
- Backend
    - C#
    - Sql
    - .Net 6
    - Asp.Net core web api
    - ADO.Net/Entity Framework Core    
- Infra
    - Git
    - Docker
    - Azure Sql Databases
    - Azure App Service
    - Github Actions
    - Github Secrets
    - Sonar Cloud
    - Trello
- Code Quality
    - XUnit
    - Sonar Cloud
- FrontEnd
    - HTML
    - CSS
    - JavaScript
    - Angular
    - TypeScript
    - [Canvas](https://www.w3schools.com/graphics/canvas_drawing.asp)
- external api
    - [pokeapi.co](https://pokeapi.co/)
    - [Socket.io](https://github.com/doghappy/socket.io-client-csharp)
    - If time permits gmail [login](https://developers.google.com/gmail/api/quickstart/dotnet)

# (Personal notes)
## Todo for the project
- Logging in/logging out functionality
- People can draw a pokemon in the website (canvas)
- They can go in blind (no image assistance) or with an image to look at
- When they’re done, compare the drawing to the sprite (front version) 
- Socket.io for a competitive gaming aspect where player 1 draws the pokemon and player 2 guesses what it is, and if it’s right player 1 wins a point. 
- Display information on the pokemon
- Save the images drawn by the user to the DB
- (Users can download their image to their computer?)
- Display all drawings by rating or time stamp
- Allow users to rate drawings
