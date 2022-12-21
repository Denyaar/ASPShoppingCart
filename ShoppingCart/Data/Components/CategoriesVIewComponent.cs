using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Data.Components;

public class CategoriesVIewComponent:ViewComponent
{
    private readonly ShoppingCartDataContext _context;

    public CategoriesVIewComponent(ShoppingCartDataContext context)
    {
        this._context = context;
    }

    public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());

}