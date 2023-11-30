using System;
class Rational
{
    private int num;
    private int denom;
    public Rational(int num, int denom)
    {
        this.num = num;
        this.denom = denom;
    }
    public static bool operator == (Rational r1, Rational r2)
    {
        if (ReferenceEquals(r1, r2))
        {
            return true;
        }
        if ((object)r1 == null || (object)r2 == null)
        {
            return false;
        }
        return r1.num == r2.num && r1.denom == r2.denom;
    }
    public static bool operator != (Rational r1, Rational r2)
    {
        return !(r1 == r2);
    }
    public static bool operator < (Rational r1, Rational r2)
    {
        return ((float)r1.num / r1.denom) < ((float)r2.num / r2.denom);
    }
    public static bool operator > (Rational r1, Rational r2)
    {
        return ((float)r1.num / r1.denom) > ((float)r2.num / r2.denom);
    }
    public override bool Equals(object rr)
    {
        if (GetType() != rr.GetType() || rr == null )
        {
            return false;
        }

        Rational r = (Rational)rr;
        return this == r; 
    }
    public static bool operator <= (Rational r1, Rational r2)
    {
        if (((float)r1.num / r1.denom) <= ((float)r2.num / r2.denom))
        {
            return true;
        }
        return false; 
    }
    public static bool operator >=(Rational r1, Rational r2)
    {
        if (((float)r1.num / r1.denom) >= ((float)r2.num / r2.denom))
        {
            return true;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return num ^ denom;
    }
    public static Rational operator +(Rational r1, Rational r2)
    {
        int a = (r1.num * r2.denom + r2.num * r1.denom);
        int b = (r2.denom * r1.denom);
        return new Rational(a, b);
    }
    public static Rational operator -(Rational r1, Rational r2)
    {
        int a = (r1.num * r2.denom - r2.num * r1.denom);
        int b = (r2.denom * r1.denom);
        return new Rational(a, b);
    }
    public static Rational operator ++(Rational r1)
    {
        int a = r1.num++;
        return new Rational(a, r1.denom);
    }
    public static Rational operator --(Rational r1)
    {
        int a = r1.num--;
        return new Rational(a, r1.denom);
    }
    public static explicit operator float(Rational r1)
    {
        return (float)r1.num / r1.denom;
    }

    public static explicit operator int(Rational r1)
    {
        return r1.num / r1.denom;
    }
    public override string ToString()
    {
        return num + "/" + denom;
    }
    public static Rational operator *(Rational r1, Rational r2)
    {
        int a = (r1.num * r2.num);
        int b = (r1.denom * r2.denom);
        return new Rational(a, b);
    }
    public static Rational operator /(Rational r1, Rational r2)
    {
        int a = (r1.num * r2.denom);
        int b = (r1.denom * r2.num);
        return new Rational(a, b);
    }
    public static Rational operator %(Rational r1, Rational r2)
    {
        int a = r1.num / r2.denom;
        Rational b = new Rational(a, 1);
        Rational c = r1 - b;
        return c*r2;
    }
}