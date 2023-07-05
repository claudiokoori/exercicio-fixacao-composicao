using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Enums;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int numOrders = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numOrders; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string nameProd = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProd = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(nameProd, priceProd);
                OrderItem orderItem = new OrderItem(quantity, priceProd, product);
                
                order.AddItem(orderItem);

            }

            Console.WriteLine(order);
        }
    }
}