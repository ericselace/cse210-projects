using System;

public class Fraction
{
    private int _top ;
    private int _bottom;
    public Fraction ()
    {
       _top= 1;
       _bottom= 1;
    }
    public Fraction( int wholeNumber)
    {
        _top= wholeNumber;
        _bottom = 1;
    }
    public Fraction( int top , int bottom)
    {
        _top = top;
        _bottom= bottom == 0? 1 : bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public void setTop(int top )
    {
        _top= top;
    }
    public int Getbottom()
    {
        return _bottom;
    }
    public void setbottom( int bottom)
    {
        if(bottom !=0)
        {
        _bottom= bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero. Value unchanged."); 
        } 
    } 
     public string GetFractionString() { return $"{_top}/{_bottom}"; } public double GetDecimalValue() { return (double)_top / _bottom;
        
    }

}