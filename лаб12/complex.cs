using System;
public class Complex
{
    public double real { get; }
    public double im { get; }

    public Complex(double real, double im)
    {
        this.real = real;
        this.im = im;
    }
    public override string ToString()
    {
        return $"{real}{((im >= 0)? "+" : "-")}{Math.Abs(im)}i";
    }
    public static Complex operator +(Complex a, Complex b)
    {
        double r = a.real + b.real;
        double imag = a.im + b.im;
        return new Complex(r, imag);
    }
    public static Complex operator -(Complex a, Complex b)
    {
        double r = a.real - b.real;
        double i = a.im - b.im;
        return new Complex(r, i);
    }
    public static Complex operator *(Complex a, Complex b)
    {
        double r = a.real * b.real - a.im* b.im;
        double i = a.real * b.im + a.im * b.real;
        return new Complex(r, i);
    }
    public static bool operator ==(Complex a, Complex b)
    {
        if (ReferenceEquals(a, b))
            return true;

        if (a is null || b is null)
            return false;

        return a.real == b.real && a.im == b.im;
    }
    public static bool operator !=(Complex a, Complex b)
    {
        return !(a == b);
    }
}
