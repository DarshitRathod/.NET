using System;
using System.Threading;
namespace Vector
{
    class Vector
    {
		int a,b;
		public Vector()
		{}
		public Vector(int a,int b)
		{
			this.a = a;
			this.b = b;
		}
		public void over(int p , int q)
		{
			Console.WriteLine("Integer Overload");
			Console.WriteLine(p + " " + q);
		}
		public void over(Vector x,Vector y)
		{
			Console.WriteLine("Vector Overload");
			Console.WriteLine("{0}+{1}={2}",x.a,y.a,x.a + y.a);
			Console.WriteLine("{0}+{1}={2}",x.a,y.a,x.a + y.a);
		}
		public void over(int[,]m , int [,]n)
		{
			int i,j,k,sum=0;
			int [,]z = new int[3,3];
			Console.WriteLine("Matrix Multipication");
			for(i=0;i<3;i++)
			{
				for(j=0;j<3;j++)
				{
					for(k=0;k<3;k++)
					{
						sum  = sum+ m[j,k] * n[k,j];
					}	
					z[i,j] = sum ;
				}
			}
			for(i=0;i<3;i++)	
			{
				for(j=0;j<3;j++)	
				{
					Console.Write("{0}"+" ",z[i,j]);
				}	
				Console.WriteLine();
			}	
		}
		
	}
	
	class Imp
	{
		static void Main(String []args)
		{
			
			Vector v1 = new Vector(2,3);
			Vector v2 = new Vector(1,2);
			Vector v3 = new Vector();
			v3.over(10,20);
			v3.over(v1,v2);
		int [,]a1 = new int[,] {
				
				{1,2,3},
				{1,2,3},
				{1,2,3},
			} ;
			int [,]a2 = new int[,] {
				
				{1,2,3},
				{1,2,3},
				{1,2,3},
			} ;
			v3.over(a1,a2);
		}
		
	}
}	