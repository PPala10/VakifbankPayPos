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

    [HttpGet]
    public IActionResult AddPos()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddPos(Pos pos)
    {
        pos.createDate = DateTime.UtcNow;
        pos.updateDate = DateTime.UtcNow;
        pos.isActive = true;

        _context.Pos.Add(pos); 
        await _context.SaveChangesAsync();

        TempData["SuccessMessage"] = "POS cihazı başarıyla eklendi.";
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var pos = _context.Pos.FirstOrDefault(p => p.posID == id);

        _context.Pos.Remove(pos);
        _context.SaveChanges();
        TempData["SuccessMessage"] = "POS cihazı başarıyla silindi.";
        
        return RedirectToAction(nameof(Index));
    }
}