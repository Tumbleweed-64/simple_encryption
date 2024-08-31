#include <iostream>

int main()
{
	std::string cipher[26];
	std::string rowSep = "-----------------------------------------------------\n";
	std::string subTable = rowSep + "|A|B|C|D|E|F|G|H|I|J|K|L|M|N|O|P|Q|R|S|T|U|V|W|X|Y|Z|\n" + rowSep + "|";
	std::cout << "Welcome to the substitution cipher maker!\n";
	std::cout << "Enter the letters for your cipher one at a time.\n";
	for (int i = 0; i < 26; i++)
	{
		std::cout << "Enter the next value! (current: no. " << i+1 << ") ";
		std::cin >> cipher[i];
		subTable += cipher[i];
		subTable += "|";
	}
	subTable += ("\n" + rowSep);
	// Make substitution table
	std::cout << "\nHere's a substitution table for your cipher: \n\n";
	// Example encoded message
	std::cout << subTable << "\n\nEXAMPLE\n";
	std::cout << "The phrase \"SECRET MESSAGE\" in your substitution cipher is \"";
	// "secret "
	std::cout << cipher[18] << cipher[4] << cipher[2] << cipher[17] << cipher[4] << cipher[19] << " ";
	// "message"
	std::cout << cipher[12] << cipher[4] << cipher[18] << cipher[18] << cipher[0] << cipher[6] << cipher[4] << "\"";
	return 0;
}
