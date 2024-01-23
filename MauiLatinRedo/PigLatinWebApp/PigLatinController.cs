using Microsoft.AspNetCore.Mvc;
using PigLatinClassLibrary1.Services;

namespace PigLatinWebApp;


[Route("api/mobile/[controller]")]
[ApiController]
public class PigLatinController(IPigLatinTranslatorService pigLatinTranslator) : ControllerBase
{
    [HttpGet]
    public async Task<string> TranslateToPigLatin(string phrase)
    {
        throw new NotImplementedException();
    }


}
