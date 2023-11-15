#nullable disable warnings

class Program
{
    static void Main(String[] args)
    {
		string alphabet = "abcdefghijklmnopqrstuvwxyz";
        Console.WriteLine("Welcome to the Ceasar Shifter!");
		Console.Write("Enter some text to encrypt: ");
		string text = Console.ReadLine();
		string encrypted = "";
		text = text.ToLower();
		Console.Write("Enter the shift (1-26): ");
		int shift = int.Parse(Console.ReadLine());
		if ((shift > 26) || (shift <= 0))
		{
			Console.WriteLine("\nThat shift is out of the range provided. ");
		}
		else if ((shift <= 26) && (shift > 0))
		{
			for (int i = 0; i < text.Length; i++)
			{
					int found = alphabet.IndexOf(text[i]);
					int shifted = found + shift;
					if (shifted > 26)
					{
						shifted -= 26;
					}
					encrypted += (text[i].ToString()).Replace(alphabet[found], alphabet[shifted]);
			}
			Console.WriteLine("The encrypted message is: " + encrypted);
		}
    }
}
