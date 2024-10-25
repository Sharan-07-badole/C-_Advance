using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_Await
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// static method we have to call with class name , but here main(function calling) and
			// method are in same class , so we can call directly method name.
			Task1();
			Task2();
			Task3();
			Task4();
			Console.ReadLine();
		}
		// Static method 
		public static  async void Task1()
		{
			await Task.Run(() =>
			{
				Console.WriteLine("Task1 starting....");
				Thread.Sleep(4000);  // 1sec is equal to 1000 means 4sec 
				Console.WriteLine("Task1 ended...");
			});
		}
		public static async void Task2()
		{
			await Task.Run(() =>
			{
				Console.WriteLine("Task2 starting....");
				Thread.Sleep(3000);
				Console.WriteLine("Task2 ended...");
			});
            Console.WriteLine("Hello Good Morning");
		}
		public static async void Task3()
		{
			await Task.Run(() =>
			{
				Console.WriteLine("Task3 starting....");
				Thread.Sleep(5000);
				Console.WriteLine("Task3 ended...");
			});
		}
		public static async void Task4()
		{
			await Task.Run(() =>
			{
				Console.WriteLine("Task4 starting....");
				Thread.Sleep(1000);
				Console.WriteLine("Task4 ended...");
			});
		}
	}
}
