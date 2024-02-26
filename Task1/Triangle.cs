using System;

namespace Task1;

public readonly record struct Triangle(double A, double B, double C) : IShape {
	public double GetArea() {
		double p = (A + B + C) / 2;

		return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
	}

	public bool IsRight() {
		(double a, double b, double c) = (A, B, C);

		if(a < b)
			(a, b) = (b, a);
		if(b < c)
			(b, c) = (c, b);
		if(a < b)
			(a, b) = (b, a);

		return a*a == b*b + c*c;
	}
}
