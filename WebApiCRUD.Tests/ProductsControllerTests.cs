using Xunit;
using WebApiCRUD.Controllers;
using WebApiCRUD.Models;
using Microsoft.EntityFrameworkCore;
using WebApiCRUD.Data;
using System.Threading.Tasks;
using web04.Data;

public class ProductsControllerTests
{
    [Fact]
    public async Task GetAll_ReturnsEmptyList_WhenNoProducts()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;

        using var context = new AppDbContext(options);
        var controller = new ProductsController(context);

        var result = await controller.GetAll();

        Assert.Empty((System.Collections.IEnumerable)result);
    }
}
