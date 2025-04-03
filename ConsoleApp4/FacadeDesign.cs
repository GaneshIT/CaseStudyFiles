using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    // Subsystem 1
    // The Subsystem can accept requests either from the facade or from the client directly. 
    // In this case, from the Subsystem, the Facade is also a client
    // Facade is not a part of the Subsystem.
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
    // Subsystem 2
    // The Subsystem can accept requests either from the facade or from the client directly. 
    // In this case, from the Subsystem, the Facade is also a client
    // Facade is not a part of the Subsystem.
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    // Subsystem 3
    // The Subsystem can accept requests either from the facade or from the client directly. 
    // In this case, from the Subsystem, the Facade is also a client
    // Facade is not a part of the Subsystem.
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }

    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            //Get the Product Details
            Product product = new Product();
            product.GetProductDetails();
            //Make the Payment
            Payment payment = new Payment();
            payment.MakePayment();
            //Send the Invoice
            Invoice invoice = new Invoice();
            invoice.Sendinvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }
}



/*
 * e-ShoppingCart
 */