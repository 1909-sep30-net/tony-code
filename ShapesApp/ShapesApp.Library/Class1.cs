using System;

namespace ShapesApp.Library
{

    //an interface is a contract that classes can delclare themselves 
    //as following 
    //without public it is internal 
   public  interface IShape
    {
         int dimensions{get;}
         int sides{get;}
         double Area{get;}
         double GetPerimeter();
    }
}
