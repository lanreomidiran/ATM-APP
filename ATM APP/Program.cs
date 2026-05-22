using System;

class Program
{
    static void Main(string[] args)
    {
        // Predefined account balance
        decimal balance = 5000000;

        // PIN setup
        const string correctPin = "1111";
        int pinAttempts = 0;
        bool isAuthenticated = false;

        Console.WriteLine("Welcome to ALABAZ ATM APP");

        // PIN Authentication
        while (pinAttempts < 3)
        {
            Console.Write("Enter your 4-digit PIN: ");
            string enteredPin = Console.ReadLine();

            if (enteredPin == correctPin)
            {
                isAuthenticated = true;
                break;
            }
            else
            {
                pinAttempts++;
                Console.WriteLine("Incorrect PIN.");

                if (pinAttempts < 3)
                {
                    Console.WriteLine($"Attempts remaining: {3 - pinAttempts}");
                }
            }
        }

        // Exit if PIN is not verified
        if (!isAuthenticated)
        {
            Console.WriteLine("Too many incorrect attempts. Card blocked.");
            return;
        }

        bool exit = false;

        // ATM Menu Loop
        while (!exit)
        {
            Console.WriteLine("\n1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Check Balance
                    Console.WriteLine($"Current Balance: ₦{balance}");
                    break;

                case "2":
                    // Deposit Money
                    Console.Write("Enter amount to deposit: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        if (depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine("Deposit successful.");
                            Console.WriteLine($"Current Balance: ₦{balance}");
                        }
                        else
                        {
                            Console.WriteLine("Deposit amount must be greater than zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                    break;

                case "3":
                    // Withdraw Money
                    Console.Write("Enter amount to withdraw: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                    {
                        if (withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine("Withdrawal successful.");
                                Console.WriteLine($"Current Balance: ₦{balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Withdrawal amount must be greater than zero.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount entered.");
                    }
                    break;

                case "4":
                    // Exit
                    Console.WriteLine("Thank you for using ALABAZ ATM APP. Goodbye!");
                    exit = true;
                    break;
                
                case "5":
                    // Transfer Money (Optional Feature)
                    Console.Write("Enter recipient's account number: ");
                    exit = true;
                    break;




                default:
                    // Invalid menu option
                    Console.WriteLine("Invalid selection. Please choose between 1 and 5.");
                    break;
            }
        }
    }
}
