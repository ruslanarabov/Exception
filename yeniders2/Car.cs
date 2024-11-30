using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeniders2
{
    public class Car
    {
        private static int _counter = 0;
        public int CarId {get;}
        public string Brand {get; set;}
        public string Model {get; set;}
        public Type Type {get; set;}
        public Car(string brand, string model, Type type )
        {
            Brand = brand;
            Model = model;
            Type = type;
        }

        public Car()
        {
            CarId = ++ _counter;
        }

        public override string ToString()
        {
            return $"CarId: {CarId} Brand: {Brand} Model: {Model} Type: {Type}";
        }
    }
}