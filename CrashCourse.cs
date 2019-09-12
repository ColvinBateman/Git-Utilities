//Putting a const in front of something makes it only allowed to have the value assigned to it upfront
//for instance, if you have a const bool of true, and try to make of false, you can't.

//If I want a string, and am not sure about the amount of things I want in the string, I can simply say something like
//string[] things = new string[5]

//If I want a loop to go through an array, I can do something like the following example
//for (int i=0; i < writers.Length; i++)//for the new int of i, as long as i is less than the writers array, and each loop makes i go up one,
//{
//  string writer = writers[i];//assigns the current writer in the string to the current i value
//  Console.WriteLine(writer);//tells you what the writer is in the earlier string
//}
//Alternatively
//foreach (string writer in writers)//for every defined writer in the writers string
//{
//  Console.WriteLine(writer);//says the writer from the earlier string
//}

