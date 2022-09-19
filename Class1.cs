using System;

public class Class1
{
	public Class1()
	{
		A = 1;
		for (int T=1; T<=5; T++)
        {
			A = A + 1;
        }
		A = A + 3;
		Console.WriteLine(A);
	}
}
