using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeynalabdiddyRuhuGelmis.DAL.Contexts;
using ZeynalabdiddyRuhuGelmis.DAL.Models;
using ZeynalabdiddyRuhuGelmis.DAL.ModelViews;

namespace ZeynalabdiddyRuhuGelmis.BL.Services;

public class SpecialNiggaHelpService
{

    IdiotNiggerDBContext _kantekst = new IdiotNiggerDBContext();

    public NiggaThatNeedHelp monkey = null;

    public EvolveNiggaVM ExistsInHuntList = null;


    #region BuyNigger   (Create)

    public void AddPoorNigger(CreateNiggaHelpVM Black_CreatureVM)
    {
        NiggaThatNeedHelp New_slav3 = new NiggaThatNeedHelp();
        
        //Mapping to Afrika
        New_slav3.ForWhat = Black_CreatureVM.ForWhat;
        New_slav3.About = Black_CreatureVM.About;
        New_slav3.WeGot = Black_CreatureVM.WeGot;
        New_slav3.WeNeed = Black_CreatureVM.WeNeed;

        New_slav3.Img = Guid.NewGuid() + Black_CreatureVM.Image.FileName;
        string upPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadedImages", New_slav3.Img);

        if(!Directory.Exists(Path.GetDirectoryName(upPath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(upPath));
        }

        using Stream fs = new FileStream(upPath, FileMode.Create);

        Black_CreatureVM.Image.CopyTo(fs);

        _kantekst.niggasThatNeedHelp.Add(New_slav3);
        _kantekst.SaveChanges();
    }

    #endregion


    #region BeatNigger  (Read)

    public List<NiggaThatNeedHelp> GetAllMonkeys()
    {
        return _kantekst.niggasThatNeedHelp.ToList();
    }

    public NiggaThatNeedHelp GetMonkeyById(int SeriaNomresi)
    {
        return _kantekst.niggasThatNeedHelp.Find(SeriaNomresi);
    }

    public EvolveNiggaVM GetMonkeyByIdLikeVM(int SeriaNomresi)
    {
        NiggaThatNeedHelp monke = _kantekst.niggasThatNeedHelp.Find(SeriaNomresi);

        EvolveNiggaVM black_nigga = new EvolveNiggaVM()
        { 
            About = monke.About,
            ForWhat = monke.ForWhat,
            WeGot = monke.WeGot,
            WeNeed = monke.WeNeed,
        };
        return black_nigga;
        
    }

    #endregion


    #region EvolveNigger (Update)

    public void EvolveNigNigNigNIg(int id, EvolveNiggaVM Buffed_CreatureVM)
    {
        NiggaThatNeedHelp Slave = GetMonkeyById(id);

        if (Buffed_CreatureVM.ForWhat is not null) { Slave.ForWhat = Buffed_CreatureVM.ForWhat; }
        if (Buffed_CreatureVM.About is not null) { Slave.About = Buffed_CreatureVM.About; }
        if (Buffed_CreatureVM.WeNeed is not null) { Slave.WeNeed = Buffed_CreatureVM.WeNeed.Value; }
        if (Buffed_CreatureVM.WeGot is not null) { Slave.WeGot = Buffed_CreatureVM.WeGot.Value; }
        if (Buffed_CreatureVM.Image is not null)
        {
            using Stream stream = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadedImages", Slave.Img), FileMode.Create);

            Buffed_CreatureVM.Image.CopyTo(stream);
        }
        _kantekst.SaveChanges();
    }

    #endregion


    #region DropNukeToNigger   (Delete)

    public void KillNigga(int bad_nigger_Serial_number)
    {
        NiggaThatNeedHelp Bad_Nigger = GetMonkeyById(bad_nigger_Serial_number);
        _kantekst.niggasThatNeedHelp.Remove(Bad_Nigger);

        Bad_Nigger = monkey;
        _kantekst.SaveChanges();
    }

    #endregion
}
