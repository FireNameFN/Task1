using System;

namespace Task1.Test;

static class Program {
	static void Main() {
		Circle[] circles = [ new(1), new(2), new(10), new(0.56) ];
		Triangle[] triangles = [ new(1, 1, 1), new(3, 4, 5), new(5, 3, 4), new(6, 10, 8) ];

		Console.WriteLine("Circles");

		foreach(Circle circle in circles)
			Console.WriteLine($"{circle.Radius} - {circle.GetArea()}");

		Console.WriteLine("\nTriangles");

		foreach(Triangle triangle in triangles)
			Console.WriteLine($"{triangle.A} {triangle.B} {triangle.C} - {triangle.GetArea()} - {(triangle.IsRight() ? "Right" : "Not right")}");
	}
}
