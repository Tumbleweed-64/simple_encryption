#nullable disable warnings

class Program
{
    static void Main(String[] args)
    {
		string alphabet = "abcdefghijklmnopqrstuvwxyz ";
		string[] morse = {"∙-", "-∙∙∙", "-∙-∙", "-∙∙", "∙", "∙∙-∙", "--∙", "∙∙∙∙", "∙∙", "∙---", "-∙-", "∙-∙∙", "--", "-∙", "---", "∙--∙", "--∙-", "∙-∙", "∙∙∙", "-", "∙∙-", "∙∙∙-", "∙--", "-∙∙-", "-∙--", "--∙∙", " "};
		string encoded = "";
        Console.WriteLine("Welcome to the morse encoder!");
		Console.Write("Enter some text to encode: ");
		string decoded = Console.ReadLine();
		decoded = decoded.ToLower();
		for (int i = 0; i < decoded.Length; i++)			
		{
			int alphaIndex = alphabet.IndexOf(decoded[i]);
			encoded += (decoded[i].ToString()).Replace(alphabet[alphaIndex].ToString(), morse[alphaIndex]);
			encoded += " ";
		}
		Console.WriteLine("\nThe encoded text is: " + encoded);
    }
}
