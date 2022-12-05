using System;
namespace Pizza{
    public abstract class Pizza{
        private void MakeBase(){
            Console.WriteLine($"Making the base of {PizzaType()}pizza");
        } 
        private void AddTopings(){
             Console.WriteLine($"Adding toppings of {PizzaType()}pizza");
        }
        private void BakePizza(){
             Console.WriteLine($"Baking of {PizzaType()}pizza");
        } 

        public abstract string PizzaType();
        public abstract void SetPrice(double price);
         public abstract double GetPrice();
        public void MakePizza(){
            MakeBase();
            AddTopings();
            BakePizza();
            Console.WriteLine($"your {PizzaType()}pizza is ready");

        }
    }
}