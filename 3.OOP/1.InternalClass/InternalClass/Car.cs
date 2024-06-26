using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalClass
{
    // It Can only be accessed within the same assambley
    internal class Car
    {
        // Member variable 
        // Private: It can not be used outside the class or is hiden from other classes
        // Also called: Backing field of the Model Property
        // private string _model;
        private string _brand;
        // private bool _isluxury;

        // PROPERTIES - We use this format when we don't need to modify our property ( No member variables needed )
        public string Model { get ; set ; }

        // We use this format when we want to modify our property
        public string Brand {
            get {
                if (Isluxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else {
                    return _brand;
                }
            } 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You've entered nothing");
                    _brand = "DefaultValue";
                }
                else {
                    _brand = value; 
                }
            } 
        }

        public bool Isluxury { get; set; }

        // CONSTRUCTOR
        public Car(string model, string brand, bool isluxury) {
            Model = model;
            Brand = brand;
            Isluxury = isluxury;

            Console.WriteLine($"A new {brand} for the model {model} has been created");
        }
    }
}
