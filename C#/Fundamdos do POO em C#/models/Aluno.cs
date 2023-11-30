using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamdos_do_POO_em_C_.models
{
	public class Aluno : Person
	{
		public Aluno() { }
		public Aluno(string name) : base(name) { }
		public double Nota { get; set; }
		public override void toPresent()
		{
			Console.WriteLine($"Olá, meu nome é {Name}, tenho {Age} anos, e sou um aluno nota {Nota}");
		}
	}
}