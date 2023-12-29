using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution2
{
	public bool DivisorGame(int n)
	{
		return recursive(n);
	}

	public bool recursive(int n)
	{
		// base case
		if (n == 1) return false;
		else if (n < 1) return false;
		for (int i = 1; i < n; i++)
		{
			if (n % i == 0)
			{
				if (recursive(n - i) == false) return true;
			}
		}

		return false;
	}
	static void Main(string[] args)
	{
		Solution2 s = new Solution2();
		bool res = s.DivisorGame(5);
		Console.WriteLine(res);
	}
}
	
