using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtables
{
    public class FirstRepeatedCharacter
    {
        //find the first repeated character in a string

        //We know that the number of possible characters is 256 (for simplicity assume ASCII characters
        //only). Create an array of size 256 and initialize it with all zeros.For each of the input characters
        //go to the corresponding position and increment its count. Since we are using arrays, it takes
        //constant time for reaching any location.While scanning the input, if we get a character whose
        //counter is already 1 then we can say that the character is the one which is repeating for the first time.
        public string FirstDuplicateCharUsingArray(string str)
        {
            int[] intArray = new int[256];
            for (int i = 0; i < 256; i++)
                intArray[i] = 0;

            for (int i = 0; i < str.Length; i++)
            {
                var asciiCode = (int)str[i];
                if (intArray[asciiCode] > 1)
                    return str[i].ToString();
            }
            return "No Repeated Char!!";
        }


    }
}
