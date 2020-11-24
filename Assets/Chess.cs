using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess
{
	//Converts x,y integer notation to chess Algebraic Notation (a1 b1 etc)
	public static string GetAlgebraicNotation(int x, int y)
	{
		//This is dumb, but I dont know a better way of converting
		//0 to A, 1 to B, etc
		//97 is where lower case characters begin in the ASCII table.
		byte[] temp = new byte[1] {(byte)(x+97)};
		string x_algebraic = System.Text.Encoding.ASCII.GetString(temp, 0, 1);

		string y_algebraic = System.Convert.ToString(y+1);

		return System.String.Concat(x_algebraic, y_algebraic);
	}
}
