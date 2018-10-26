using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcaoPerfil
    {
        public int CdPerfilAcesso { get; set; }
        public long IdAcessoAcao { get; set; }
        public string FlInserir { get; set; }
        public string FlEditar { get; set; }
        public string FlExcluir { get; set; }
        public string FlAcesso { get; set; }

        public PerfilAcesso CdPerfilAcessoNavigation { get; set; }
        public AcessoAcao IdAcessoAcaoNavigation { get; set; }
    }
}
