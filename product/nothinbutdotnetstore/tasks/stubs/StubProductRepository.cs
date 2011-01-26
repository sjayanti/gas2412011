using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.web.model;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubProductRepository : ProductsRepository
    {
        public 	IEnumerable<Product> get_products_in_department(Department department)
        {
            return Enumerable.Range(1, 100).Select(x => new Product { name = x.ToString("Product 000") });
            
        }
	}
}