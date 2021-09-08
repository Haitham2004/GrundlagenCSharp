using System;

class Icalc
{
	static void Main(string[] args)
	{
		string wert1, wert2, wert;
		double zahl1, zahl2;

		wert1 = args[0];

		wert = args[1];

		wert2 = args[2];

		zahl1 = Double.Parse(wert1);
		zahl2 = Double.Parse(wert2);

		if (wert == "+")
			Console.WriteLine(zahl1 + zahl2);

		else if (wert == "-")
			Console.WriteLine(zahl1 - zahl2);
		else if (wert == "*")
			Console.WriteLine(zahl1 * zahl2);
		else if (wert == "/")
			Console.WriteLine(zahl1 / zahl2);



	}
}