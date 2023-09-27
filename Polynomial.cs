using System.Collections.Generic;
using System;

public class Polynomial : ICloneable
{
    // A reference to the first node of a singly linked list
    private Node<Term> front;
    // Creates the zero polynomial, i.e. 0
    public Polynomial()
    { }
    
// Inserts term t into the current polynomial in its proper order
// If a term with the same exponent already exists then the two terms are added together
// If the two terms cancel out then no new term is created
public void AddTerm(Term t)
    {
    
    }
   
// Adds polynomials p and q to yield a new polynomial
public static Polynomial operator +(Polynomial p, Polynomial q)
    {
    
    }
   
// Multiplies polynomials p and q to yield a new polynomial
public static Polynomial operator *(Polynomial p, Polynomial q)
    {
    
    }
    
// Evaluates the current polynomial at x and returns the result
public double Evaluate(double x)
    {
    
    }
  
// Creates and returns a clone of the current polynomial except that the exponents
// of the current polynomial are assigned to the coefficients of the clone in reverse order
// For example, 4x^3 – 3x + 9 is cloned as 9x^3 – 3x + 4
public Object Clone()
    {
        Stack<int> S; // Stack of exponents
}
    
// Prints the current polynomial
public void Print()
    {
    
    }
   
}//EOC
