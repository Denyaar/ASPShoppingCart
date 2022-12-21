using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Data;

namespace ShoppingCart.Controllers;

public class ProductsController : Controller
{
    private readonly ShoppingCartDataContext _context;

    public ProductsController(ShoppingCartDataContext context)
    {
        this._context = context;
    }
    // GET
    public async  Task<IActionResult> Index(string categorySlug = "", int p= 1)
    {
        int pageSize = 3;
        ViewBag.PageNumber = p;
        ViewBag.PageRank = pageSize;
        ViewBag.CategorySlug = categorySlug;
        return View();
    }
}