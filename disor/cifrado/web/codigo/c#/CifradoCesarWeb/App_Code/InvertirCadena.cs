using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// </summary>
public class InvertirCadena
{
	public InvertirCadena()
	{
	}
	public String invertirCadena(String texto)
	{
		char[] charArray = texto.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}
}