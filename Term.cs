using System;

public class Term : IComparable
{
    private double coefficient;
    private int exponent;
    // Implement public read and write properties for each data member
    // The set property of exponent should raise an ArgumentOutOfRangeException
    // if value is less than 0 or greater than 20 (3 marks)
    // Constructor: Creates a term with the given coefficient and exponent
    public Term(double coefficient, int exponent)
    {
    }
    // Evaluates the current term at x and returns the result
    public double Evaluate(double x)
    {
    }
    // Returns -1, 0, or 1 if the exponent of the current term
    // is less than, equal to, or greater than the exponent of obj
    // Raises an ArgumentException if obj is either null or not a term
    public int CompareTo(Object obj)
    {
    }
    // Returns a string representation of the current term
    public override string ToString()
    {
    }

}//EOC