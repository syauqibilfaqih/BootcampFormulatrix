﻿namespace Dumper;
public static class ThisExtension
{
    public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}
