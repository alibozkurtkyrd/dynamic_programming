using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divsor_game
{
	public class Solution
	{
		public bool DivisorGame(int n)
		{
			return recursive(n, new Dictionary<int, bool>());
		}

		public bool recursive(int n, Dictionary<int, bool> MemoArray)
		{
			// base case
			if (n == 1)
			{
				return false;
			}
			else if (n < 1) return false;

			if (MemoArray.ContainsKey(n))
				return MemoArray[n];

			for (int i = 1; i < n; i++)
			{
				if (n % i == 0)
				{
					if (recursive(n - i, MemoArray) == false)
					{
						if (!MemoArray.ContainsKey(n-i))
							MemoArray.Add(n-i, true);
						return true;
					}
				}
			}
			MemoArray.Add(n, false);
			return false;
		}
		static void Main(string[] args)
		{
			Solution s = new Solution();
			bool res = s.DivisorGame(6);
			Console.WriteLine(res);
		}
	}
}
