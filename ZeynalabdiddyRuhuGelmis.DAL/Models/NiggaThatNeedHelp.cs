using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeynalabdiddyRuhuGelmis.DAL.Models;


public abstract class Monkey
{
    public int Id { get; set; }
}

public class NiggaThatNeedHelp : Monkey
{

    public string ForWhat { get; set; }
    public string About { get; set; }
    public double WeGot { get; set; } 
    public double WeNeed { get; set; }
    public string Img { get; set; }
}
