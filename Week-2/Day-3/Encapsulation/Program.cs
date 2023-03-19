using Encapsulation;

BankAccount myAccount = new BankAccount();

// Set the account number
string myAccountNumber = "27346834682";
myAccount.SetAccountNumber(myAccountNumber);
myAccount.SetBalance(1000);
myAccount.SetAccountHolder("Mustafa Ibrahim");

// Deposit some money
myAccount.Deposit(1907);

// Withdraw some money
myAccount.Withdraw(100);

// Print the account number
Console.WriteLine($"Account number: {myAccount.GetAccountNumber()}");

// Print the account holder
Console.WriteLine($"Account holder: {myAccount.GetAccountHolder()}");

// Print the balance
Console.WriteLine($"Balance: {myAccount.GetBalance()}");
