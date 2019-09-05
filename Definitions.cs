//This is a personal list of things to do or keep in mind in c#

//Math

//Int
//When doing math between multiple "int"s, you can
//add them together with +
//subtract one from the other with -
//multiple them with *
//divide one by the other with /
//Keep in mind that the order of operations is still relevant in c#
//As such, you can put the ints between ( ) that you want to be done first
//Ints will always produce an interger, no decimals or fractions allowed
//similar to the dividing, you can find the remainder using %
//Intergers have a maximum and minimum value, you can use them by making an int "int.MaxValue" or int.MinValue"
//If an int goes over the maximum, or under the minimum, the number will  wrap around. This is called an "overflow" or "underflow"
//Double
//Very similar to int, but is able to use decimal points, and has a larger amount of minimum and maximum values
//Decimal
//Very similar to double, but sacrifices a wider amount of values for a higher amount of precision, being able to have more decimal points
//Remember to add an "M" to the end of the decimal

//Branches and Loops

//Bool
//Will tell if something is true or false
//If
//A boolean statement that does something IF a requirement is done
//Else
//Added after an if statement. If the if statement is not met, the else will follow through instead
//Conditionals
// == means equality
// && means and
// || means or
//Loops
//While
//As long as a certain criteria is not met, the loop will continue. For instance, if it needs to count to a certain number before ending
//Do ... while
//Like while, but it executes the code first before checking it
//For
//Uses three parts in its statement to determine the loop
//initializer declares a value and sets it
//condition declares until what the loop stops
//iterator declares what changes the loop variable per loop
// ++ is used to go up one int, you can use these in loops to count each time

//example
//int sum = 0;//defines the sum that is taken later
//for (int number = 1; number< 21; number++)//for the number that begins at one, as long as the number is below 21, add another one each loop
//{
//  if (number % 3 == 0) //if number, having the remainder of three, is 0
//  {
//    sum = sum + number; //the sum earlier is added to the number in the condition
//  }
//}
//Console.WriteLine($"The sum is {sum}"); //as the loop is finished, take the sum from earlier and say what it is in the output


