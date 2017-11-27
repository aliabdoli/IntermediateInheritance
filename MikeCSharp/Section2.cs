using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MikeCSharp.Section1
{
	public class Constructors
	{
		public Constructors(params int[] arg1)
		{
			
		}
		
		
	}

    public class IndexerSample
    {
        public IndexerSample this[string key]
        {
            get { return new IndexerSample(); }
            set
            {
                var ss = value;
            }
        }
    }

    public class RefOutModifier
	{
		readonly List<int> ss = new List<int>(); 
		//readonly int ss = -1; 
		public void DoSomething(ref int i)
		{
			i++;
		}

		public void DoSomething1(out int i)
		{
			//int i = 0;
			i = 0;
			i++;
		}

	}
	public static class Client
	{
		public static void CreateClasses()
		{
			var ss = new Constructors(1);
		}

		public static void CallRefOutModifier()
		{
			
		}
	}
}
