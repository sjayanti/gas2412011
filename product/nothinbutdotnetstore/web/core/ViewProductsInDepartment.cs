using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.core.stubs;
using nothinbutdotnetstore.web.model;

namespace nothinbutdotnetstore.web.core
{
	public class ViewProductsInDepartment :ApplicationCommand
	{
        ProductsRepository repository;
        Renderer renderer;

		public ViewProductsInDepartment()
			: this(new StubProductRepository(),
            new StubRenderer())
        {
        }

        public ViewProductsInDepartment(ProductsRepository repository, Renderer renderer)
        {
            this.repository = repository;
            this.renderer = renderer;
        }

        public void run(Request request)
        {
			renderer.display(repository.get_products_in_department(request.map<Department>()));
        }
	}
}