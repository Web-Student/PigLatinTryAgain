using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinClassLibrary1.Services;

public interface IPigLatinTranslatorService
{
    public Task<string> TranslateToPigLatin(string toTranslate);
}
