using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Comment
{
    public string author;
    public string text;  
    public Comment(string author, string text)
    {
        author= author;
        text= text;

    }
    public override string ToString() 
    { 
        return $"{author}: {text}";
    }

}