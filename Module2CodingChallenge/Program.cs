using Module2CodingChallenge;

//create new Polygon Object and Square Object
Polygon polygon = new Polygon (3); // a triangle
Square square = new Square(4.5f);  // a square

Pentagon pentagon = new Pentagon(5); // a pentagon
Octagon octagon = new Octagon(8); // an Octagon



//Create a ne Player with one life and add points to the player's score
Player player = new Player("Zoe", 1);
player.AddPoints(100);


//Display player's score
Console.WriteLine("Welcome to the game! Your score is " + player.GetScore()
    + " You have " + player.GetLivesLeft() + " lives left!");

//kill off the player's charater
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attacks you, Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");