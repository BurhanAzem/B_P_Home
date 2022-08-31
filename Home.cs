
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
 
             var Builder = new HomeBuilder();
             Builder
             .SetCity("Nablus")
             .SetStreet(1024)
             .SetSpace(200);
             Builder.BuildMyHome();

            
        }
    }
}


public class Home
{
    public string? City { get; set; }
    public int? Street { get; set; }
    public int? Space { get; set; }
}

public interface IHomeBuilder
{
    public IHomeBuilder SetCity(string city);
    public IHomeBuilder SetStreet(int street);
    public IHomeBuilder SetSpace(int space);
}

public class HomeBuilder : IHomeBuilder
{
    private  Home home = new Home();
    
    public IHomeBuilder SetCity(string city)
    {
        home.City=city;
        return this;
    }
    public IHomeBuilder SetStreet(int street)
    {
        home.Street=street;
        return this;
    }
    public IHomeBuilder SetSpace(int space)
    {
        home.Space=space;
        return this;
    }
    public Home BuildMyHome()
    {
        return home;
    }

}