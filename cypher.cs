using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
      Console.WriteLine("Enter a secret message: ");
      string input = Console.ReadLine();
      char[] secretMessage = input.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];

      for (int i = 0; i < secretMessage.Length; i++){
       char letter = secretMessage[i];
       int index = Array.IndexOf(alphabet, letter);
       int indexPlus = (index + 3) % 26;
       char newLetter = alphabet[indexPlus];
       encryptedMessage[i] = newLetter;
      
      }
      string encodedString = String.Join("", encryptedMessage);
      Console.WriteLine(encodedString);
    }
  }
}
