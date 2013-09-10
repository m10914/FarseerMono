using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
	using System.Diagnostics;

	using FarseerMono;
	using FarseerMono.Dynamics;
	using FarseerMono.Factories;

	class Program
	{
		static void Main(string[] args)
		{
			var world = new World(new Vector2(-5, -5));

			/*for (int i = 0; i < 1000; i++)
			{
				BodyFactory.CreateRectangle(world, 10, 10, 0.1f, new Vector2(i * 10, 0), null);
			}*/
			Body bdy = BodyFactory.CreateRectangle(world, 10, 10, 0.5f, Vector2.One, null);
			bdy.IsStatic = false;
			bdy.BodyType = BodyType.Dynamic;
			bdy.Restitution = 0.3f;
			bdy.Friction = 0.3f;

			Stopwatch timer = new Stopwatch();
			timer.Start();

			for (int j = 0; j < 1000; j++)
			{
				world.Step(16f);
				Console.WriteLine("Pos: " + bdy.Position.Y);
			}
				

			Console.WriteLine("Total time: " + timer.ElapsedMilliseconds);

			Console.ReadKey();
		}
	}
}
