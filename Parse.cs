//Parsing and Format Providers
/*
using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        string[] values = { "1,304.16", "$1,456.78", "1,094", "152",//the values intented to be used in this string
                          "123,45 €", "1 304,16", "Ae9f" };
        double number;//defines "number" as a double
        CultureInfo culture = null;//defines a culture, as in a real culture on earth?

        foreach (string value in values)//in this loop, each time there is a value in the string above
        {
            try//attempt to 
            {
                culture = CultureInfo.CreateSpecificCulture("en-US");//the culture is assigned to a United States culture
                number = Double.Parse(value, culture);//number is assigned as the value and then the culture
                Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);//write out the name, value, and number from earlier info
            }
            catch (FormatException)//and if that doesn't work
            {
                Console.WriteLine("{0}: Unable to parse '{1}'.",//says that it's unable to work with the number for the US categorization
                                  culture.Name, value);
                culture = CultureInfo.CreateSpecificCulture("fr-FR");//sets it to french instead
                try
                {
                    number = Double.Parse(value, culture);
                    Console.WriteLine("{0}: {1} --> {2}", culture.Name, value, number);
                }
                catch (FormatException)
                {
                    Console.WriteLine("{0}: Unable to parse '{1}'.",//once again says it's unable to work with the number, but with french instead
                                      culture.Name, value);
                }
            }
            Console.WriteLine();
        }
    }
}
// The example displays the following output:
//    en-US: 1,304.16 --> 1304.16
//    
//    en-US: Unable to parse '$1,456.78'.
//    fr-FR: Unable to parse '$1,456.78'.
//    
//    en-US: 1,094 --> 1094
//    
//    en-US: 152 --> 152
//    
//    en-US: Unable to parse '123,45 €'.
//    fr-FR: Unable to parse '123,45 €'.
//    
//    en-US: Unable to parse '1 304,16'.
//    fr-FR: 1 304,16 --> 1304.16
//    
//    en-US: Unable to parse 'Ae9f'.
//    fr-FR: Unable to parse 'Ae9f'.
*/

//Parsing and NumberStyles Values
/*
using System;
using System.Globalization;

public class Example
{
    public static void Main()
    {
        string value = "1,304";//giving a string a value of those numbers
        int number;//defines number as an int
        IFormatProvider provider = CultureInfo.CreateSpecificCulture("en-US");//sets the provider to say the US culture
        if (Int32.TryParse(value, out number))
            Console.WriteLine("{0} --> {1}", value, number);//write the culture, the value, and the number
        else
            Console.WriteLine("Unable to convert '{0}'", value);//says its unable to convert the culture, and displays the value

        if (Int32.TryParse(value, NumberStyles.Integer | NumberStyles.AllowThousands,
                          provider, out number))
            Console.WriteLine("{0} --> {1}", value, number);
        else
            Console.WriteLine("Unable to convert '{0}'", value);
    }
}
// The example displays the following output:
//       Unable to convert '1,304'
//       1,304 --> 1304
*/

//Parsing and Unicode Digits
/*
using System;

public class Example
{
    public static void Main()
    {
        string value;
        // Define a string of basic Latin digits 1-5.
        value = "\u0031\u0032\u0033\u0034\u0035";
        ParseDigits(value);

        // Define a string of Fullwidth digits 1-5.
        value = "\uFF11\uFF12\uFF13\uFF14\uFF15";
        ParseDigits(value);

        // Define a string of Arabic-Indic digits 1-5.
        value = "\u0661\u0662\u0663\u0664\u0665";
        ParseDigits(value);

        // Define a string of Bangla digits 1-5.
        value = "\u09e7\u09e8\u09e9\u09ea\u09eb";
        ParseDigits(value);
    }

    static void ParseDigits(string value)
    {
        try
        {
            int number = Int32.Parse(value);//sets the int number to the parse of the value
            Console.WriteLine("'{0}' --> {1}", value, number);//writes the culture, value, and number
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to parse '{0}'.", value);
        }
    }
}
// The example displays the following output:
//       '12345' --> 12345
//       Unable to parse '１２３４５'.
//       Unable to parse '١٢٣٤٥'.
//       Unable to parse '১২৩৪৫'.
*/