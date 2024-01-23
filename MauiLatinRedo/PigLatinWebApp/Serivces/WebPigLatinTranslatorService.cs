using PigLatinClassLibrary1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PigLatinWebApp.Serivces;

public class WebPigLatinTranslatorService : IPigLatinTranslatorService
{
    public async Task<string> TranslateToPigLatin(string toTranslate)
    {
        return $"oopsay no orkway (not enough time to actually implement the translation of {toTranslate})";
    }

    


}




