using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Bank
    {
        public void Create()
        {
            //db connection
            //insert command
            //sql select command
        }
    }

    public abstract class Customer
    {
        public abstract void Discount();

    }

    public class SilverCustomer:Customer
    {
        public override void Discount()
        {
            //
        }
    }
    public class GoldCustomer :Customer
    {
        public override void Discount()
        {
            //
        }
    }

    public class Client
    {
        public void ShowDiscount(Customer obj)
        {

        }
    }

    public interface IGCustomer
    {
        void Gold();
    }
    public interface ISCustomer
    {
        void Silver();
    }
    public interface IPCustomer
    {
        void Platinum();
    }
    public interface ICustomer
    {
        void Gold();
        void Silver();
        void Platinum();
    }
    public interface IGSCustomer
    {
        void Gold();
        void Silver();
    }
    //public interface IPCustomer
    //{
    //    void Platinum();
    //    void Silver();
    //}
    public class Airtel : IPCustomer
    {
        public void Gold()
        {
            throw new NotImplementedException();
        }

        public void Platinum()
        {
            throw new NotImplementedException();
        }

        public void Silver()
        {
            throw new NotImplementedException();
        }
    }

    //How to create objec
    //SilverCustomer obj=new SilverCustomer();

    public interface IAll : IPCustomer, IGSCustomer
    {

    }
    class Product1 : IPCustomer, IGSCustomer
    {
        public void Gold()
        {
            throw new NotImplementedException();
        }

        public void Platinum()
        {
            throw new NotImplementedException();
        }

        public void Silver()
        {
            throw new NotImplementedException();
        }
    }
}
