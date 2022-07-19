using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPC.Infrastructure.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.Cars = new HashSet<Car>();
        }

        public int Id { get; init; }

        public string Name { get; set; }

        public IEnumerable<Car> Cars { get; init; }
    }
}
