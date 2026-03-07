using System;
using System.Data;
public class cardHolder
{
    String cardNum;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
    }

    public String getNum()
    {
        return cardNum;
    }
    {
    public int getPin()
    {
        return pin;
    }

    public String getFirstName()
    {
        return firstName;
    }

    public String getlastName()
    {
        return lastName;
    }

    public double getBalance()
    {
        return balance;
    }

    public void setNum(String newCardNum)
    {
        cardNum = newCardNum;
    }

    public void setPin(int newPin)
    {
        pin = newPin;
    }

    public void setFirstName(String newFirstName)
    {
        firstName = newFirstName;
    }

    public void setLastName(String newLastName)
    {
        lastName = newLastName;
    }

    public void setBalance(double newBalance)
    {
        balance = newBalance;
    }

    public static void Main(String[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...")
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. ShowBalance");
            Console.WriteLine("4. Exit");
        }
    }
    void deposit(cardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to deposit? ");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.setBalance(deposit);
        Console.WriteLine( "Thank you for your $$. Your new balance is: + currentUser.getBalance())";
    }
    void withdraw(cardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to withdraw: ");
        double withdrawal = Double.Parse(Console.ReadLine());
        //Check if the user has enough money
        if (currentUser.getBalance() > withdrawal)
        {
            Console.WriteLine("Insufficient balance :(");
        }
        else
        {
            currentUser.setBalance(currentUser.getBalance() + withdrawal);
            Console.WriteLine("You're good to go! Thank you:)");
        }
    }

    void balance(cardHolder currentUser)
    {
        Console.WriteLine("current balance: " + currentUser.getBalance());
    }

    List<cardHolder> cardHolders = new List<cardHolder>(); 
    cardHolders.Add(new cardHolder("4532772818527395", 1234, "Lanre", "Omidiran", 150.31));
    cardHolders.Add(new cardHolder("4532772818527396", 5678, "Lanre", "Abdulahi", 150.32));
    cardHolders.Add(new cardHolder("4532772818527397", 5050, "Lanre", "Abefe", 150.33));
    cardHolders.Add(new cardHolder("4532772818527398", 6060, "Lanre", "Lekki", 150.34));
    cardHolders.Add(new cardHolder("4532772818527399", 7070, "Lanre", "Omident", 150.35));

    // Prompt user
    Console.WriteLine("Welcome to SimpleATM");
    Console.WriteLine("Please insert your debit card: ");
    string debitCardNum = "";
    cardHolder currentUser;





}


}

    
    }

}

    override Tab to accept 
}
