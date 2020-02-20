using System;
using System.Collections.Generic;
using WidgetClasswork_InheritanceLibrary;

namespace WidgetClasswork_Inheritance {
    class Program {
        static void Main(string[] args) {

            //create a new collection
            var collection = new List<Product>();
            //for statements to create the correct number
            for (var idx = 0; idx < 3; idx++) {
                collection.Add(new BronseWidget());
            }
            //for (var idx = 0; idx < 7; idx++) {
            //    collection.Add(new SilverWidget());
            //}
            //for (var idx3 = 0; idx3 < 9; idx3++) {
            //    collection.Add(new GoldWidget());
            //}

            var total = 0.0;
            foreach (var widget in collection) {
                //Console.WriteLine($"Widget is model {widget.GetModelName()} made in {widget.GetStateName()}");//should display the model
                total += widget.GetPrice();
            }
            Console.WriteLine($"total is {total}");

        }
    }
}
