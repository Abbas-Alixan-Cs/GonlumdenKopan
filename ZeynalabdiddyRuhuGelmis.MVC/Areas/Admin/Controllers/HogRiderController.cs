using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using ZeynalabdiddyRuhuGelmis.BL.Services;
using ZeynalabdiddyRuhuGelmis.DAL.Models;
using ZeynalabdiddyRuhuGelmis.DAL.ModelViews;

namespace ZeynalabdiddyRuhuGelmis.MVC.Areas.Admin.Controllers;

[Area("Admin")]
public class HogRiderController : Controller
{

    SpecialNiggaHelpService _CIA = new SpecialNiggaHelpService();

    #region BuyNigger   (Create)

    [HttpGet]
    public IActionResult BuyNigga()
    {
        return View();
    }

    [HttpPost]
    public IActionResult BuyNigga(CreateNiggaHelpVM Black_AbominationVM)
    {
        _CIA.AddPoorNigger(Black_AbominationVM);
        return RedirectToAction("Index", "Dashboard");
    }


    #endregion


    #region EvolveNigger (Update)

    [HttpGet]
    public IActionResult EvolveNigga(int id)
    {
        EvolveNiggaVM Black_Abomination = _CIA.GetMonkeyByIdLikeVM(id);
        if(Black_Abomination == _CIA.ExistsInHuntList)
        {
            return BadRequest("Bu meymun Uyutulub");
        }
        return View(Black_Abomination);
    }

    [HttpPost]
    public IActionResult EvolveNigga( int id, EvolveNiggaVM Black_AbominationVM)
    {
        _CIA.EvolveNigNigNigNIg(id, Black_AbominationVM);
        return RedirectToAction("Index", "Dashboard");
    }

    #endregion


    #region DropNukeToNigger   (Delete)

    public IActionResult KillNigga(int id)
    {

        _CIA.KillNigga(id);
        return RedirectToAction("Index", "Dashboard");
    }

    #endregion
}
