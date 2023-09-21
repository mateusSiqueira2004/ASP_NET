using Microsoft.AspNetCore.Mvc;

namespace Atividade1_ASP_Net.Controllers
{
    [Route("~/")]
    [ApiController]
    public class AtividadeController
    {
        [HttpGet]
        public string executaAtividade()
        {          
            return "Hello Word!";
        }
        [HttpGet("/bsm")]
        public string GenerationBSM()
        { 
            return "\n\nRESPONSABILIDADE PESSOAL\n\nMENTALIDADE DE CRESCIMENTO\n\nORIENTAÇÃO PARA O FUTURO\n\nPERSISTÊNCIA\n\nCOMUNICAÇÃO\n\nTRABALHO EM EQUIPE\n\nPROATIVIDADE\n\nORIENTAÇÃO AO DETALHE"; 
        }
        [HttpGet("/objetivo")]
        public string Objetivo()
        {
            return "Feedback e aprendizagem contínua";
        }
    }
}
