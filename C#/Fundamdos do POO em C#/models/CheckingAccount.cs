using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamdos_do_POO_em_C_.models.CheckingAccount
{
	public class CheckingAccount
	{
		public CheckingAccount(int countNumber, decimal initialBalance)
		{
			AccountNumber = countNumber;
			balance = initialBalance;
		}
		public int AccountNumber { get; set; }
		private decimal balance;
		public void Draw(decimal value)
		{
			if (balance >= value)
			{
				balance -= value;
				Console.WriteLine("Saque realizado com sucesso");
			}
			else
			{
				Console.WriteLine("Valor desejado é maior que o saldo disponível");
			}
		}
		public void DisplayBalance()
		{
			Console.WriteLine("Seu saldo disponível é: " + balance);
		}
	}
}