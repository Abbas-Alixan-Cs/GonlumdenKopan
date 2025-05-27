using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeynalabdiddyRuhuGelmis.DAL.ModelViews;

public class EvolveNiggaVM
{
    public string? ForWhat { get; set; }
    public string? About { get; set; }
    public Nullable<double> WeGot { get; set; }
    public Nullable<double> WeNeed { get; set; }
    public IFormFile? Image { get; set; }
}
