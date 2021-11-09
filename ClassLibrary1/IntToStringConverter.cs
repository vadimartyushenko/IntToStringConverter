using System.Text;
//using NUnit.Framework;

namespace DataWorksTasks
{
	public class IntToStringConverter
	{
		private readonly char[] _charsContainer = new char[]{'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

	    /*[TestCase(2225, ExpectedResult = "2225")]
		[TestCase(-1503, ExpectedResult = "-1503")]
		[TestCase(int.MinValue, ExpectedResult = "-2147483648")]
		[TestCase(int.MaxValue, ExpectedResult = "2147483647")]*/
		public string Convert(int num)
		{
			var temp = new StringBuilder();

			if (num == int.MinValue) return "-2147483648";

			string sign = "";
			if (num < 0)
			{
				num = -num;
				sign = "-";
			}

			while (num > 0)
			{
				temp.Insert(0, _charsContainer[num % 10]);
				num /= 10;
			}

			return string.IsNullOrWhiteSpace(sign) ? temp.ToString() : sign + temp.ToString();
		}

	}
}