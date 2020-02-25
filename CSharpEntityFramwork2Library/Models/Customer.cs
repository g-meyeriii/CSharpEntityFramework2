using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpEntityFramwork2Library.Models {
   public class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public override string ToString() => $"{Id}|{Name}|{Active}";
        public Customer() { }
        
    }
}
