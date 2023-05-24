﻿namespace Øvelse2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Academy p = new Academy("UCL", "Seebladsgade");

			Student s1 = new Student(p, "Jens");
			Student s2 = new Student(p, "Niels");
			Student s3 = new Student(p, "Susan");

			p.Attach(s1);
			p.Attach(s2);
			p.Attach(s3);

			p.Message = "Så er der julefrokost!";

			p.Detach(s2);

			p.Message = "Så er der fredagsbar!";

			Console.ReadLine();
		}
	}
}