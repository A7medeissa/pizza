using System;
namespace Pizza{
    
    
     
     public class Beef_Pizza : Pizza{
        private static double Price;
        public override double GetPrice()
        {
           return Price;
        }
         public override void SetPrice(double price)
        {
            Price=price;
        }

        public override string PizzaType()
        {
            return "Beef ";
            
        }

       
    }
     
}