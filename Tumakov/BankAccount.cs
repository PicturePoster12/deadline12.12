using System;
namespace Tumakov
{
	public enum BankAccountType
	{
		current,
		savings,
	}
	public class Bank
	{
		private static int nextAccountNumber = 100000;
		private int accountNumber;
		private decimal balance;
		private BankAccountType accountType;
        public Bank(decimal balance = 0, BankAccountType accountType = BankAccountType.current)
        {
            accountNumber = AccNumbGenerator();
            Balance = balance;
            AccountType = accountType;
        }
        public int AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}
		public decimal Balance
		{
			get { return balance; }
			set {
				if (value >= 0)
					balance = value;
				else
					throw new FormatException();
			}
		}
		public BankAccountType AccountType
		{
			get { return accountType; }
			set { accountType = value; }
		}
		private static int AccNumbGenerator()
		{
			return nextAccountNumber++;
		}
		public decimal Withdraw(decimal withdraw)
		{
			if (withdraw >= 0)
			{
				if (balance >= withdraw)
				{
					balance -= withdraw;
					Console.WriteLine($"Вы сняли {withdraw} руб.");
				}
				else
				{
					Console.WriteLine("Не удалось выполнить операцию. Недостаточно средств.");
				}
				Console.WriteLine($"Баланс: {balance} руб.");
				return balance;
			}
			else
			{
				throw new FormatException();
			}
		}
		public decimal Deposit(decimal deposit)
		{
			if (deposit >= 0)
			{
				balance += deposit;
				Console.WriteLine($"Вы положили на счёт {deposit} руб. Баланс: {balance} руб.");
				return balance;
			}
			else
			{
				throw new FormatException();
			}
		}
        public void Print()
		{
			Console.WriteLine($"Номер счета: {accountNumber}");
			Console.WriteLine($"Баланс: {balance:F2}");
			Console.WriteLine($"Тип счета: {accountType}");
		}
		public void Transfer(Bank destinationAccount, decimal summa)
		{
			if (summa <= 0 | summa > this.Balance)
			{
				throw new FormatException();
			}
			else
			{
				this.Balance -= summa;
				destinationAccount.Balance += summa;
			}
		}
    }
}