using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigPizzaBoss.Pizzas;

namespace BigPizzaBoss.Ingredients
{
    class Crust : Ingredient
    {
        private const string name = "корж";

        public Crust(Pizza pizza) : base(pizza, name)
        {

        }
    }
}
