using System;

class ATM
{
	static void Main(string[] args)
	{
		string Pin_Code = "1234";
		int balance = 50000;

		Console.Write("Enter your PIN: ");
		string enteredPin = Console.ReadLine();

		if (enteredPin == Pin_Code)
		{
			Console.WriteLine("PIN accepted. Welcome!");

			bool exit = false;

			while (!exit)
			{
				Console.WriteLine("\n--- Menu ---");
				Console.WriteLine("1. Current Balance");
				Console.WriteLine("2. Withdraw");
				Console.WriteLine("3. Deposit");
				Console.WriteLine("4. Exit");
				Console.Write("Choose an option: ");

				string input = Console.ReadLine();

				switch (input)
				{
				case "1":
					Console.WriteLine($"Current Balance = {balance}");
					break;

				case "2":
					Console.Write("Enter amount to withdraw: ");
					if (int.TryParse(Console.ReadLine(), out int withdrawAmount))
					{
						if (withdrawAmount > 0 && withdrawAmount <= balance)
						{
							balance -= withdrawAmount;
							Console.WriteLine($"Withdrawal successful. New balance = {balance}");
						}
						else
						{
							Console.WriteLine("Invalid amount or insufficient funds.");
						}
					}
					else
					{
						Console.WriteLine("Invalid input.");
					}
					break;

				case "3":
					Console.Write("Enter amount to deposit: ");
					if (int.TryParse(Console.ReadLine(), out int depositAmount))
					{
						if (depositAmount > 0)
						{
							balance += depositAmount;
							Console.WriteLine($"Deposit successful. New balance = {balance}");
						}
						else
						{
							Console.WriteLine("Amount must be greater than zero.");
						}
					}
					else
					{
						Console.WriteLine("Invalid input.");
					}
					break;

				case "4":
					Console.WriteLine("Thank you for using the ATM. Goodbye!");
					exit = true;
					break;

				default:
					Console.WriteLine("Invalid option. Try again.");
					break;
				}
			}
		}
		else
		{
			Console.WriteLine("Incorrect PIN. Access denied.");
		}
	}
}
