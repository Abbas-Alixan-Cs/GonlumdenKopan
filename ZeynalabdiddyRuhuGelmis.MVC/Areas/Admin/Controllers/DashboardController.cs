using Microsoft.AspNetCore.Mvc;
using ZeynalabdiddyRuhuGelmis.BL.Services;


namespace ZeynalabdiddyRuhuGelmis.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    SpecialNiggaHelpService _CIA = new SpecialNiggaHelpService();
    public IActionResult Index()
    {
        return View(_CIA.GetAllMonkeys());
    }
}
