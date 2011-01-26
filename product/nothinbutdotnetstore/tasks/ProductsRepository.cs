using System.Collections.Generic;
using nothinbutdotnetstore.web.model;

namespace nothinbutdotnetstore.tasks
{
    public interface ProductsRepository
    {
		IEnumerable<Product> get_products_in_department(Department department);
	}
}