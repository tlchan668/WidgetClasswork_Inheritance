using System;
using System.Collections.Generic;
using System.Text;

namespace WidgetClasswork_InheritanceLibrary {
    public class BronseWidget : Product{

        ModelType price { get; set; }//= ModelType.Bronse;
        public BronseWidget()
        {
            price = ModelType.Bronse;
            //Model = ModelType.Bronse;
        }

        public override double GetPrice() {
            return (double) price;
        }
    }
}
