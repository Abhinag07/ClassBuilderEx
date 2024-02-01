using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBuilderEx
{
	internal class Program
	{
		static void Main(string[] args)
		{
			OrderBuilder orderBuilder;
			OrderShop shop = new OrderShop();

			orderBuilder = new MealOne();
			shop.Construct(orderBuilder);
			orderBuilder.Order.showdetails();

			orderBuilder = new MealTwo();
			shop.Construct(orderBuilder);
			orderBuilder.Order.showdetails();

			orderBuilder = new MealThree();
			shop.Construct(orderBuilder);
			orderBuilder.Order.showdetails();

			orderBuilder = new MealFour();
			shop.Construct(orderBuilder);
			orderBuilder.Order.showdetails();

			Console.ReadLine();
		}
	}
	class OrderShop
	{
		public void Construct(OrderBuilder orderBuilder)
		{
			orderBuilder.mealItem1();
			orderBuilder.mealItem2();
			orderBuilder.mealItem3();
			orderBuilder.mealItem4();
		}
	}

	abstract class OrderBuilder
	{
		protected Order order;
		public Order Order { get { return order; } }

		public abstract void mealItem1();
		public abstract void mealItem2();
		public abstract void mealItem3();
		public abstract void mealItem4();
	}
	class MealOne : OrderBuilder
	{
		public MealOne() { 
		order = new Order("Meal_One");
		}
		public override void mealItem1()
		{
			order["MainItem"] = "Cheese Burger";
		}

		public override void mealItem2()
		{

			order["Shake"] = "Choclate Shake";
		}

		public override void mealItem3()
		{
			order["Dessert"] = "Ice Cream";
		}

		public override void mealItem4()
		{
			order["Toy"] = "Hot Wheels";
		}
	}
	class MealTwo : OrderBuilder
	{
		public MealTwo()
		{
			order = new Order("Meal_Two");
		}
		public override void mealItem1()
		{
			order["MainItem"] = "Ham Burger";
		}

		public override void mealItem2()
		{

			order["Shake"] = "Strawberry Shake";
		}

		public override void mealItem3()
		{
			order["Dessert"] = "Muffin";
		}

		public override void mealItem4()
		{
			order["Toy"] = "Bike";
		}
	}
	class MealThree : OrderBuilder
	{
		public MealThree()
		{
			order = new Order("Meal_Three");
		}
		public override void mealItem1()
		{
			order["MainItem"] = "Veg Burger";
		}

		public override void mealItem2()
		{

			order["Shake"] ="Oreo Shake";
		}

		public override void mealItem3()
		{
			order["Dessert"] = "Cupcake";
		}

		public override void mealItem4()
		{
			order["Toy"] = "Transformer";
		}
	}
	class MealFour : OrderBuilder
	{
		public MealFour()
		{
			order = new Order("Meal_Four");
		}
		public override void mealItem1()
		{
			order["MainItem"] = "Maharaja Burger";
		}

		public override void mealItem2()
		{

			order["Shake"] = "Walnut Shake";
		}

		public override void mealItem3()
		{
			order["Dessert"] = "Cake";
		}

		public override void mealItem4()
		{
			order["Toy"] = "Barbie";
		}
	}


	class Order
	{
		private string ordertype;
		private Dictionary<string, string> orderdata = new Dictionary<string, string>();

		public Order(string order)
		{
			this.ordertype = order;
		}
		public string this[string key]
		{
			get { return orderdata[key]; }
			set { orderdata[key] = value; }
		}
		public void showdetails()
		{
            Console.WriteLine("----------------------------------------");
			Console.WriteLine("Order Type = {0}\n", ordertype);
			Console.WriteLine("Item One = {0}", orderdata["MainItem"]);
			Console.WriteLine("Item Two = {0}", orderdata["Shake"]);
			Console.WriteLine("Item Three = {0}", orderdata["Toy"]);
			Console.WriteLine("Item Four = {0}", orderdata["Dessert"]);
            Console.WriteLine("----------------------------------------");

        }
	}
}
