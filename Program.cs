using System;

namespace test
{
	class Program
	{
		static void Main(string[] args)
		{
			// Fråga om användaren vill kryptera eller dekryptera
			Console.WriteLine("Vill de kryptera eller tolka ett meddelande?");
			Console.WriteLine("[1]: Kryptera");
			Console.WriteLine("[2]: Dekryptera");
			Console.Write("Ditt val: ");
			string choice = Console.ReadLine();
			choice = "" + choice[0];

			// Fråga användaren om en textsträng
			Console.WriteLine("Ditt meddelande...");
			Console.Write(": ");
			string message = Console.ReadLine();

			// Kryptera eller dekryptera strängen
			switch (choice)
			{
				case "1":
					// Kryptera
					message = ShiftMessage(message, false);
					break;
				case "2":
					// Avkryptera
					message = ShiftMessage(message, true);
					break;
				default:
					Console.WriteLine("Ogiltligt val.");
					return;
			}

			// Ge tillbaka resultatet i terminalen
			Console.Write("Ditt resultat: ");
			Console.WriteLine(message);
		}

		static string ShiftMessage(string message, bool decrypt)
		{
			string newMessage = "";
			int offset = 4;
			for (int i = 0; i < message.Length; i++)
			{
				int myChar = message[i];
				if (decrypt)
				{
					myChar = myChar - offset;
				}
				else
				{
					myChar = myChar + offset;
				}
				newMessage = newMessage + (char)myChar;
			}
			return newMessage;
		}
	}
}
