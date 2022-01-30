using System.Collections.Generic;

namespace curso.api.Models.Users
{
    public class ValidateFieldViewModelOutput
    {
        public IEnumerable<string> Erros { get; private set; }

        public ValidateFieldViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
