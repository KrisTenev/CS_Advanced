using _405_StaticClasses;

//New instance could not be created

BankHelper.Name = "UBB";
BankHelper.CalcualteDebt(55);


Account.Tax = 20;

Account account = new Account();
account.Balance = 100;

Account account2 = new Account();
account2.Balance = 2000;

account.PayTax();
account2.PayTax();

Console.WriteLine(account.Balance);
Console.WriteLine(account2.Balance);

Console.WriteLine(Account.GetBankName());