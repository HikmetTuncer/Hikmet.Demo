using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hikmet.Demo.Entities
{
    public abstract class Food
    {
        public int Price { get; set; }
    }

    public class Kebab : Food
    {
        public int Id { get; set; }
    }


    public class Pizza : Food
    {
        public int Id { get; set; }
        public string NameChanged { get; set; }
    }
}
