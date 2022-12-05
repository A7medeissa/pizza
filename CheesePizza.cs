using System;
namespace Pizza{


     public class Cheese_Pizza : Pizza{
        private static double Price;
        public override double GetPrice()
        {
            return Price;
        }
        public override void SetPrice(double p)
        {
            Price=p;
        }

        public override string PizzaType()
        {
            return "Cheese ";
            
        }


    }
}