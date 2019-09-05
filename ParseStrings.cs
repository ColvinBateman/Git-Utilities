/*
string phrase = "The quick brown fox jumps over the lazy dog.";//defines a string, this being a sentence
string[] words = phrase.Split(' ');//breaks up the words with their spaces, and creates a string out of them

foreach (var word in words)//for ever word defined in words
{
    System.Console.WriteLine($"<{word}>");//put each separate word on a line
}
*/

/*
string phrase = "The quick brown    fox     jumps over the lazy dog.";//this is the same as above but with each space counting as a new line later, it'll make a bunch of lines before and after "fox"
string[] words = phrase.Split(' ');

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}
*/

/*
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };//defines characters that need to be addressed separately from normal text

string text = "one\ttwo three:four,five six seven";//a text string of words with a bunch of junk in between them
System.Console.WriteLine($"Original text: '{text}'");//writes what's in the above string

string[] words = text.Split(delimiterChars);//makes a string of works in the text above, taking out the defined delimiter characters
System.Console.WriteLine($"{words.Length} words in text:");//writes the amount of words and then "words in text"

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");//writes each proper word
}
*/

/*
char[] delimiterChars = { ' ', ',', '.', ':', '\t' };//same as above, but there's extra spaces that get written out

string text = "one\ttwo :,five six seven";
System.Console.WriteLine($"Original text: '{text}'");

string[] words = text.Split(delimiterChars);
System.Console.WriteLine($"{words.Length} words in text:");

foreach (var word in words)
{
    System.Console.WriteLine($"<{word}>");
}
*/

/*
string[] separatingStrings = { "<<", "..." };//defines these as delimiters

string text = "one<<two......three<four";//the text in the string
System.Console.WriteLine($"Original text: '{text}'");//writes the original text

string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);//new string, words, is the text string, separated by the delimiters
System.Console.WriteLine($"{words.Length} substrings in text:");//writes the amount of words in the text

foreach (var word in words)//for each word
{
    System.Console.WriteLine(word);//writes it down. Also to note, since the delimiter was only "<<", three and four are still stuck together with a "<". A bold reminder to always check what you're typing
}
*/