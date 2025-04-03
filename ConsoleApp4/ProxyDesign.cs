using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Empl
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Empl(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }

    // The Subject interface declares common operations for both RealSubject and the Proxy. 
    // As long as the client works with RealSubject using this interface, 
    // you will be able to pass it a proxy instead of a real subject.
    public interface ISharedFolder
    {
        void PerformRWOperations();
    }

    // The RealSubject contains some core business logic. 
    // Usually, RealSubjects are capable of doing some useful work which may be very slow or sensitive 
    // A Proxy can solve these issues without any changes to the RealSubject's code.
    public class SharedFolder : ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }

    // The Proxy has an interface identical to the RealSubject.
    class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder folder;
        private Empl employee;
        public SharedFolderProxy(Empl emp)
        {
            employee = emp;
        }
        public void PerformRWOperations()
        {
            if (employee.Role.ToUpper() == "CEO" || employee.Role.ToUpper() == "MANAGER")
            {
                folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                folder.PerformRWOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
