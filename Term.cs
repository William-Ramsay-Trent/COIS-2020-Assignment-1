using System;

public class Term : IComparable
{
    private double coefficient;
    //Property for coefficient variable
    public double Coefficient
    {
        get { return coefficient; }
        set { coefficient = value; }
    }

    private int exponent;
    //Property for exponent variable
    public int Exponent
    {
        get { return exponent; }
        set
        {
            //checks to see if set value is within range
            if (0 <= value && value <= 20)
                exponent = value;
            else
                //throws an exception and exits code
                System.Diagnostics.Debug.WriteLine(new ArgumentOutOfRangeException());
        }
    }//EOP

    // Implement public read and write properties for each data member
    // The set property of exponent should raise an ArgumentOutOfRangeException
    // if value is less than 0 or greater than 20 (3 marks)


    // Constructor: Creates a term with the given coefficient and exponent
    public Term(double coefficient, int exponent)
    {
        this.coefficient = coefficient;
        this.exponent = exponent;
    }


    // Evaluates the current term at x and returns the result
    public double Evaluate(double x)
    {
        double result = 0;

        //computes result
        result = coefficient * Math.Pow(x, exponent);

        return result;
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