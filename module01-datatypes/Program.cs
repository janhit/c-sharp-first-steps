// See https://aka.ms/new-console-template for more information

/* * ---------------------------------------------------------
*DATA TYPE CHEAT SHEET (C#)
* ---------------------------------------------------------
*Whole Numbers (Integers):
* int->Standard integers(e.g., 42, -10).
* long->Large integers(used when 'int' is too small).
*
* Decimal Numbers(Floating Point):
* double->Standard for decimals(e.g., 3.14).Use a dot(.)!
* float->Less precise(requires an 'f' suffix: 3.14f).
*
*Text & Characters:
* string->Sequences of text(e.g., "Hello World").Use "double quotes".
* char->A single character(e.g., 'A').Use 'single quotes'.
*
*Logic:
* bool->True or False(true / false).Perfect for if-statements.
* ---------------------------------------------------------
*/


// --- EXAMPLES: C# DATA TYPES IN ACTION ---

// 1. Whole Numbers (Integers)
int playerLevel = 5;
long worldSeed = 9223372036854775807L; // A very large number for map generation

// 2. Decimal Numbers (Floating Point)
double movementSpeed = 5.75; // Standard for movement
float gravityScale = 9.81f; // Note the 'f' suffix for floats

// 3. Text & Characters
string playerName = "ProGamer_2026"; // Text always in "double quotes"
char teamLogo = 'X'; // Single character in 'single quotes'

// 4. Logic (Booleans)
bool isAlive = true; // Player is still in the game
bool hasSpecialItem = false; // Inventory check



/* * ---------------------------------------------------------
* TYPE CONVERSION: HOW TO CHANGE DATA TYPES
* ---------------------------------------------------------
* 1. PARSING (Text -> Number)
* Used to turn a string (e.g., from Console.ReadLine) into a number.
* string input = "25";
* int age = int.Parse(input);
* -> Note: It crashes if the text contains letters!
*
* 2. CASTING (Number -> Number)
* Used to force one numeric type into another.
* double pi = 3.99;
* int wholeNumber = (int)pi; 
* -> Result: 3 (Warning: Decimals are truncated/cut off, not rounded!)
*
* 3. CONVERT (The All-rounder)
* A utility class that handles many types and even null values.
* string s = "true";
* bool isActive = Convert.ToBoolean(s);
* -> Note: Unlike casting, Convert.ToInt32() actually ROUNDS decimals.
* ---------------------------------------------------------
*/


/* * ---------------------------------------------------------
* EXERCISES: TYPE CONVERSION (PARSING, CASTING, CONVERT)
* ---------------------------------------------------------
* Task 1: The "Age in 10 Years" Calculator (Parsing)
* -> Take the string 'inputAge', convert it to an integer, 
* and add 10 to it. Print the result with -Console.WriteLine("Your Text comes here");-
*/
string inputAge = "15";
// TODO: Your code here

/* * Task 2: The "Experience Points" Display (Casting)
* -> You have 1500.99 XP. Your UI can only show whole numbers.
* Convert 'exactXP' to an integer using a CAST. 
* Observe: Does it round or cut off?
*/
double exactXP = 1500.99;
// TODO: Your code here

/* * Task 3: The "Smart Shop" Rounding (Convert)
* -> A price is 19.50. Use Convert.ToInt32() to turn it into an integer.
* Compare the result to Task 2. What is the difference?
*/
double price = 19.50;
// TODO: Your code here

/* * Task 4: The "Scoreboard" (ToString)
* -> You have a score of 5000 points. 
* Create a string that says: "Current Score: 5000".
* Use the .ToString() method.
*/
int score = 5000;
// TODO: Your code here

/* * Task 5: The "Admin Check" (Convert to Bool)
* -> You received the text "true" from a database.
* Convert it into a real boolean variable.
*/
string dbResponse = "true";
// TODO: Your code here


//EXERCISE SOLUTIONS:
// Task 1 Solution:
int age = int.Parse(inputAge);
age += 10;
Console.WriteLine("In 10 years, you will be: " + age);

// Task 2 Solution:
int displayedXP = (int)exactXP; // Casting truncates the decimal part
Console.WriteLine("Displayed XP (after casting): " + displayedXP); // Output: 1500  

// Task 3 Solution:
int roundedPrice = Convert.ToInt32(price); // Convert rounds the number
Console.WriteLine("Rounded Price (after Convert): " + roundedPrice); // Output: 20  

// Task 4 Solution:
string scoreText = "Current Score: " + score.ToString();
Console.WriteLine(scoreText); // Output: Current Score: 5000    

// Task 5 Solution:
bool isAdmin = Convert.ToBoolean(dbResponse);
Console.WriteLine("Is Admin: " + isAdmin); // Output: Is Admin: True    

