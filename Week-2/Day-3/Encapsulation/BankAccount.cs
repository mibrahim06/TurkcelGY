namespace Encapsulation;

/**
 * This class represents a bank account
 * Brief description:
 * This class shows how to use encapsulation to hide the data of a class
 * Functions:
 * - SetAccountNumber: Sets the account number
 * - GetAccountNumber: Gets the account number
 * - SetAccountHolder: Sets the account holder
 * - GetAccountHolder: Gets the account holder
 * - SetBalance: Sets the balance
 * - GetBalance: Gets the balance
 * - Deposit: Deposits money to the account
 * - Withdraw: Withdraws money from the account
 */
public class BankAccount
{
    // These are the private parameters of the class and can only be accessed by the methods of the class
    private string accountNumber;
    private string accountHolder;
    private decimal balance;
    
    // Mutator method for the account number
    public void SetAccountNumber(string accountNumber)
    {
        this.accountNumber = accountNumber;
    }
    
    // Accessor method for the account number
    public string GetAccountNumber()
    {
        return accountNumber;
    }
    
    // Mutator method for the account holder
    public void SetAccountHolder(string accountHolder)
    {
        this.accountHolder = accountHolder;
    }
    
    // Accessor method for the account holder
    public string GetAccountHolder()
    {
        return accountHolder;
    }
    
    // Mutator method for the balance
    public void SetBalance(decimal balance)
    {
        this.balance = balance;
    }
    
    // Accessor method for the balance
    public decimal GetBalance()
    {
        return balance;
    }
    
    // Deposit method for the balance
    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Invalid amount");
        }
        else
        {
            this.balance += amount;
        }
    }
    
    public void Withdraw(decimal amount)
    {
        if (this.balance - amount < 0)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            this.balance -= amount;
        }
    }
}
