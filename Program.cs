//Harrison Busby
//10/17/2022
//Mini Challenge 1: Hello {name}
//Make a program that uses a while loop, data validation and has the program say hello {your name}


string yourName;
string playAgain = "yes";
bool correctNumber = true;
int intActual = 0;



while(playAgain == "yes"){
Console.WriteLine("Hello, what is your name?");

yourName = Console.ReadLine();

correctNumber = Int32.TryParse(yourName, out intActual);

if(correctNumber == true){
    Console.WriteLine("Please input a valid response.");
}else{


Console.WriteLine($"Hello {yourName}");

Console.WriteLine("Would you like to play again?");
Console.WriteLine("Type yes to continue and no to stop");
string playActual= Console.ReadLine().ToLower();

if(playActual == "yes"){
    Console.WriteLine("Lets play again!");
}else if(playActual == "no"){
    Console.WriteLine("Go away");
    break;
}
}
}
