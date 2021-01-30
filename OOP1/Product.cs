using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product  //sadece özellik olur burada
    {
        public int Id { get; set; } //ana anahtar budur. Ürünleri bu ayırı tc gibi düşün
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }



    }
}
