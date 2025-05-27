using Microsoft.AspNetCore.Mvc;
using ZeynalabdiddyRuhuGelmis.BL.Services;
namespace ZeynalabdiddyRuhuGelmis.MVC.Controllers;




public class HomeController : Controller
{
    readonly SpecialNiggaHelpService _idiotNiggerService = new SpecialNiggaHelpService();
    public IActionResult Index()
    {
        return View(_idiotNiggerService.GetAllMonkeys());
    }
}
