using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities {
    public static string ProcessText(string input)//all methods will be static
    {
        //Extra: split the string on " ", put strings into array, go through array and do tryParse for each, increment a number

        //Determine whether user has input a word or a number
        //Return string "word" if user enters a word (ex. ab.23cd)
        //Same for number if number (includes decimals) (ex. 1.3)
        float num;
        if(float.TryParse(input, out num)){
            input = "Number";
        }
        else
        {
            input = "String";
        }
        return input;
    }
}
