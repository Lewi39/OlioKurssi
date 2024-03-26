using System;


class class1
{
	static void Main(string[]args)
	{




		ajoneuvo auto = new ajoneuvo();

		auto.nimi = "Toyota";

		auto.nopeus = 80;

		auto.renkaat = 4;

		auto.tulostadata();

		string autotiedot = auto.tostring();
		Console.WriteLine( autotiedot );

		Console.WriteLine();


		Ajoneuvo mopo = new Ajoneuvo();
		mopo.nimi = "Skootteri";
		mopo.nopeus = 80;
		mopo.renkaat = 2;

		mopo.tulostadata();
		Console.WriteLine(mopo.ToString());

    }
}
