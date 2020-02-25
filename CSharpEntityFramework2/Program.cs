using CSharpEntityFramwork2Library;
using System;

namespace CSharpEntityFramework2 {
    class Program {
        static void Main(string[] args) {

            var context = new AppDbContext();

            AddCustomer(context);
            
            
        }

        static void AddCustomer(AppDbContext context) {
            var cust = new Customer { 
                Id
            }
        }
    }
}
