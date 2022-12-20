using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza_slab.rab4
{
     abstract class Pizza
    {
        public Pizza (string n)
        {
            this.Name = n; 
        }
        public string Name { get; set; }
    }
    public void Prepare();
    public void Bake();
    public void Cut();
    public void Box();

}
