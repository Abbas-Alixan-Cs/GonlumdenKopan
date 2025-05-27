using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace ZeynalabdiddyRuhuGelmis.DAL.ModelViews;

public class CreateNiggaHelpVM
{
    public string ForWhat { get; set; }
    public string About { get; set; }
    public double WeGot { get; set; }
    public double WeNeed { get; set; }
    public IFormFile Image { get; set; }

}
