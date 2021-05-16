using System;
using System.Collections.Generic;
using System.Text;


/* Interfaces are just like abstract classes. You can apply the attributes of an interface towards many different classes that share the same characteristics.
The interface states the attributes, the classes define the attributes, and the main code calls the attributes/methods. */ 
namespace Training_C_Sharp.Interfaces
{
    public interface Vehicle
    {
        int num_of_wheels { get; set; }
        string color { get; set; }
        int horsepower { get; set; }
        double speed { get; set; }
        void move();
        void stop();

    }
}
