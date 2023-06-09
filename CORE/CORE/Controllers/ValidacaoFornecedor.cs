using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace CORE.Controllers
{
    internal class ValidacaoFornecedor : AbstractValidator<Fornecedor>
    {
        public ValidacaoFornecedor()
        {


            RuleFor(f => f.Razao_social).NotEmpty();
            RuleFor(f => f.Nome_fantasia).NotEmpty();
            RuleFor(f => f.Codigo).NotEmpty();

        }
    }
}
