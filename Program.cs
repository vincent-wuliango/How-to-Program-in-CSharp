// See https://aka.ms/new-console-template for more information

// E01 (Basics)

// Change the appearance of console
/*Console.Title = "Skynet";
Console.ForegroundColor = ConsoleColor.Green;
Console.WindowHeight = 40;


Console.WriteLine("Hello Unity!");

Console.ReadLine();

Console.WriteLine("My name is RX-2000.\nI'm an AI sent from future to help you");
Console.WriteLine("What is your dream?");

Console.ReadLine();

Console.WriteLine("Cool! Mine is your");

Console.ReadKey();
*/

// Challenge 1

/*Console.WriteLine("A proud knight named...");
Console.ReadLine();

Console.WriteLine("...walked into a bar. At the counter he met a...");
Console.ReadLine();

Console.WriteLine("...who asked him what he wanted to drink?");
Console.ReadLine();

Console.WriteLine("...shouted the knight! The bartender shushed him quickly");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("But it was too late... A dragon ate them both");
Console.ReadKey();
*/

// E02 (Variable)

/*Console.WriteLine("What is your name?");
string username = Console.ReadLine();
Console.WriteLine("Hello " + username + ", nice to meet you!");

int num01;
int num02;

Console.Write("Input a number: ");
num01 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Input a second number: ");
num02 = Convert.ToInt32( Console.ReadLine() );

int result = num01 * num02;
Console.WriteLine("The result is " + result);

Console.ReadKey();
*/

// Challenge 2

/*double x, y, z;
double result;

Console.Write("Input x: ");
x = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input y: ");
y = Convert.ToDouble( Console.ReadLine() );

Console.Write("Input z: ");
z = Convert.ToDouble( Console.ReadLine() );

result = (x + y + z) / 3;
Console.WriteLine("The average of these numbers is " + result);

Console.ReadKey();
*/

// E03 (Conditions)
/*int cash, change;

Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");
cash = Convert.ToInt32( Console.ReadLine() );

if (cash < 5) 
{
    Console.WriteLine("That's not enough money.");
}
else if (cash == 5)
{
    Console.WriteLine("Here is your ticket.");
}
else
{
    change = cash - 5;
    Console.WriteLine("Here is your ticket and " + change + " dollars in change.");
}

Console.ReadKey();
*/

/*int age, height;

Console.Write("Please input age: ");
age = Convert.ToInt32( Console.ReadLine() );

Console.Write("Please input height (cm): ");
height = Convert.ToInt32( Console.ReadLine() );

if (age >= 18 && height >= 160){
    Console.WriteLine("You can enter!");
} else {
    Console.WriteLine("You don't meet the requirements.");
}

Console.ReadKey();
*/

/*int num;

Console.WriteLine("Input a number between 1 and 5: ");
num = Convert.ToInt32( Console.ReadLine() );

switch (num) {
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    case 4:
        Console.WriteLine("Four");
        break;
    case 5:
        Console.WriteLine("Five");
        break;
    default:
        Console.WriteLine("Default");
        break;
}

Console.ReadKey();
*/

// Challenge 3

/*int result;

Console.Write("15 + 2 * 2 = ");
result = Convert.ToInt32( Console.ReadLine() );

if (result == 19) Console.WriteLine("Correct");
else Console.WriteLine("Wrong");

Console.Write("10 * 2 / 4 = ");
result = Convert.ToInt32( Console.ReadLine());

if (result == 5) Console.WriteLine("Correct");
else Console.WriteLine("Wrong");

Console.Write("(4 + 3 + 2 + 1) / 2 = ");
result = Convert.ToInt32( Console.ReadLine());

if (result == 5) Console.WriteLine("Correct");
else Console.WriteLine("Wrong");

Console.ReadKey();
*/

// E04 (Loops)

/*Console.Write("How many cool numbers do you want: ");

int count = Convert.ToInt32( Console.ReadLine() );

for (int i = 1; i <= count; i++) {
    double result = Math.Pow(2, i);
    Console.WriteLine(result);
}

Console.ReadKey();
*/

/*Random numberGen = new Random();

int roll = 0, attempts = 0;

Console.WriteLine("Press enter to role the dice.");

while (roll != 6) {
    Console.ReadKey();

    roll = numberGen.Next(1, 7);
    Console.WriteLine("You rolled: " + roll);
    attempts++;
}

Console.WriteLine("It tooks you " + attempts + " attempts to roll a six.");

Console.ReadKey();

*/

// Challenge 4

/*Random numberGen = new Random();
int roll01 = 0, roll02 = 1, attempts = 0;

Console.WriteLine("Press enter to roll a dice.");

while (roll01 != roll02) {
    Console.ReadKey();

    roll01 = numberGen.Next(1, 7);
    roll02 = numberGen.Next(1, 7);

    Console.WriteLine("Roll 1: " + roll01);
    Console.WriteLine("Roll 2: " + roll02);

    attempts++;
}

Console.WriteLine("It took you " + attempts + " attempts to roll two of a kind");

Console.ReadKey();
*/

// E05 (Arrays)

/*string[] movies = {"Lord of the Rings", "Fight Club", "Interstellar", "Gladiator"};

for (int i = 0; i < movies.Length; i++) {
    Console.WriteLine(i+1 + ". " + movies[i]);
}*/

/*string[] movies = new string[4];

Console.WriteLine("Type in four movies: ");

for (int i = 0; i < movies.Length; i++) {
    movies[i] = Console.ReadLine();
}

Console.WriteLine("\nHere they are aplhabetically: ");

Array.Sort(movies);

for (int i = 0; i < movies.Length; i++) {
    Console.WriteLine(movies[i]);
}*/

/*List<string> shoppingList = new List<string>();

shoppingList.Add("Dreams");
shoppingList.Add("Miracles");
shoppingList.Add("Rainbows");
shoppingList.Add("Pony");

for (int i = 0; i < shoppingList.Count; i++) {
    Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Dreams");
shoppingList.RemoveAt(1);

Console.WriteLine("------------------");

for (int i = 0; i < shoppingList.Count; i++) {
    Console.WriteLine(shoppingList[i]);
}

Console.ReadKey();
*/

// Challenge 5

/*int numbers = 0;

Console.Write("How many students are in your class: ");
numbers = Convert.ToInt32( Console.ReadLine() );

string[] names = new string[numbers];

Console.WriteLine("Please input the names of the students: ");

for (int i = 0; i < numbers; i++) {
    names[i] = Console.ReadLine();
}

Console.WriteLine("----------------------------");

Array.Sort(names);

for (int i = 0; i < names.Length; i++) {
    Console.WriteLine(names[i]);
}

Console.ReadKey();
*/

// E06 (Methods)

/*namespace My_Awesome_Program {
    class Program {
        static void Main (string[] args) {

            // MeetAlien();
            // MeetAlien();
            // MeetAlien();

            int result = Multiply(1, 3);
            Console.WriteLine("The result is " + result);

            if (result % 2 == 0) {
                Console.WriteLine(result + " is an even number");
            } else {
                Console.WriteLine(result + " is an uneven number");
            }

            Console.ReadKey();
        }

        static void MeetAlien() {
            Random numberGen = new Random();

            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm" + name);
            Console.WriteLine("I'm" + age + " years old.");
            Console.WriteLine("Oh, and I'm an Alien.\n");
        }

        static int Multiply(int a, int b) {
            int result = a * b;
            return result;
        }
    }

        static void Main(string[] args) {
            Console.Write("Enter a sentence: ");

            string sentence = Console.ReadLine();
            int result = CountWord(sentence);

            Console.WriteLine("There are " + result + " words in that sentence.");
            
            Console.ReadKey();
        }

        static int CountWord(string sentence) {
            int count = sentence.Split(' ').Length;
            return count;
        }
    }
}
*/

// E07 (Classes)

class Wizard {
    public string name;
    public string favoriteSpell;
    private int spellSlots;
    private float experience;

    public static int Count;

    public Wizard(string _name, string _favoriteSpell) {
        name = _name;
        favoriteSpell = _favoriteSpell;
        spellSlots = 2;
        experience = 0f;

        Count++;
    }

    public void CastSpell() {
        if (spellSlots > 0) {
            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
            experience += 0.3f;
        } else {
            Console.WriteLine(name + "is out of spell slots.");
        }
    }

    public void Meditate() {
        Console.WriteLine(name + " meditates to regain spell slots");
        spellSlots += 2;
    }
}

class Program {
    static void Main(string[] args) {
        Wizard wizzard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");

        wizzard01.CastSpell();

        Wizard wizzard02 = new Wizard("Glindaf Merlinson", "Abracadabra");

        wizzard02.CastSpell();

        Console.WriteLine(Wizard.Count);

        Console.ReadKey();
    }
}