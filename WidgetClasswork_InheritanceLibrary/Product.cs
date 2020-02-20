using System;

namespace WidgetClasswork_InheritanceLibrary {
    public enum ModelType { Bronse =20, Silver=90, Gold =500};

    public abstract class Product : IProduct{

        public string Code { get; set; }
        public string Name { get; set; }
        public ModelType Model { get; set; }

        public virtual double GetPrice() {
            //return Model switch
            //{
            //    ModelType.Bronse => 20,
            //    ModelType.Silver => 90,
            //    ModelType.Gold => 500,
            //    _ => 0 // everything else
            //};
            return 0;
        }

        //public Product() { }//constructor

        
    }
}
