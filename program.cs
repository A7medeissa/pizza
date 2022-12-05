using System;
using System.Collections.Generic;
namespace Pizza{
    public class program{
        public static void Main(){
            var Beefpizza= new Beef_Pizza();
            Beefpizza.SetPrice(20.0);
            var Cheesepizza= new Cheese_Pizza();
            Cheesepizza.SetPrice(15.0);
            var Chickenpizza= new Chicken_Pizza();
            Chickenpizza.SetPrice(25.0);
            
            var Beefprice = Beefpizza.GetPrice();
            Console.WriteLine($"price of beef is {Beefprice}");
            //
            var Cheeseprice = Cheesepizza.GetPrice();
            Console.WriteLine($"price of Cheese is {Cheeseprice}");
            //
            var Chickenprice = Chickenpizza.GetPrice();
            Console.WriteLine($"price of Chicken is {Chickenprice}");

            ////////////
            var Beefpizza2=new Beef_Pizza();
            Console.WriteLine($"price of beef2 is {Beefpizza2.GetPrice()}");



            while (true){

                Console.WriteLine("enter 1 for Chicken 2 for Beef 3 for Cheese Q||q for exit");
                var input =Console.ReadLine();
                 if(input=="q"|| input=="Q"){
                    break;
                 }
                switch( int.Parse(input)){
                    case 1:
                          //Chpizza= new Chicken_Pizza();
                          Chickenpizza.MakePizza();
                          break;
                    case 2:
                        //   Bpizza= new Beef_Pizza();
                          Beefpizza.MakePizza();
                          break;
                    case 3:
                          //Cheesepizza= new Cheese_Pizza();
                          Cheesepizza.MakePizza();
                          break;
                    default:
                            continue;
                           
                }

            }



        }

    }
}

