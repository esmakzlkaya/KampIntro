using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //primarykey
        public int CategoryId { get; set; } //foreignkey
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        
        //CRUD-Create-Read-Update-Delete


    }
}
