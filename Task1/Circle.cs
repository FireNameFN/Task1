using System;

namespace Task1;

public readonly record struct Circle(double Radius) : IShape {
	public double GetArea() => Radius * Radius * Math.PI;
}
