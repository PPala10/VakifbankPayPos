using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VakifPayPos.Data;
using VakifPayPos.Models;

namespace VakifPayPos.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    //Only active pos will be displayed on the home page
    public async Task<IActionResult> Index()
    {
        var products = await _context.Pos.Where(p => p.isActive).ToListAsync();
        return View(products);
    }

    public IActionResult Onboarding()
    {
        return View();
    }

    public IActionResult Checkout()
    {
        return View();
    }

}