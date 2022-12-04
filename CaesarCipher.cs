using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      Console.Write("What's your secret message?: ");

      string secretMsg = Console.ReadLine();

      // convert the user input into an array of chars
      char[] secretMessage = secretMsg.ToCharArray();

      // purely testing purposes
      // Console.WriteLine(secretMessage);

      // future array to hold shifted chars
      char[] encryptedMessage = new char[secretMessage.Length];

      // for loop to iterate through the array of chars
      for (int i = 0; i < secretMessage.Length; i++) {

        // store current letter of loop 
        char currLetter = secretMessage[i];

        // use current letter to find where it is in the 
        // alphabet and store it 
        int letterPos = Array.IndexOf(alphabet, currLetter);

        // add 3 to the letterPos to hardcode the shift
        // in the caesar cipher and modulo alphabet
        // just in case the shift goes past z which
        // would result in an indexing error
        int newLetterPos = (letterPos + 1) % alphabet.Length;

        // get new Letter from the shifted position
        char newLetter = alphabet[newLetterPos];

        encryptedMessage[i] = newLetter;

      }

      Console.WriteLine(String.Join("", encryptedMessage));
    }
  }
}