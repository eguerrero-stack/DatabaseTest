using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class Legend
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullLegend
        {
            get
            {
                return $"{FirstName} {LastName} {Weapon}";
            }
        }
        public string Weapon { get; set; }

    }
}
