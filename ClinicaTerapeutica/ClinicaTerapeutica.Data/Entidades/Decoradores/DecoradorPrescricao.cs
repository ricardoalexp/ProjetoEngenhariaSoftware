using ClinicaTerapeutica.Data.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaTerapeutica.Data.Entidades.Decoradores
{
    public abstract class DecoradorPrescricao : IPrescricao
    {
        protected Prescricao prescricao;
        public DecoradorPrescricao(Prescricao prescricao)
        {
            this.prescricao = prescricao;
        }
        public virtual string ObterDescricao()
        {
            return prescricao.ObterDescricao();
        }
        public Prescricao ObterPrescricao()
        {
            return this.prescricao;
        }
    }
}
