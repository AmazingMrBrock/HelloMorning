using System;
namespace HelloMorning
{
	public class MyClass
	{
		public int count = 0;

		public MyClass()
		{
		}

		public int newClick()
		{
			int oneClick = 1;
			count = count + oneClick;
			return count;
		}
	}
}
