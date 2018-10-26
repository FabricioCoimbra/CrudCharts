using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcaoUsuario
    {
        public int CdUsuario { get; set; }
        public long IdAcessoAcao { get; set; }
        public string FlInserir { get; set; }
        public string FlEditar { get; set; }
        public string FlExcluir { get; set; }
        public string FlAcesso { get; set; }

        public Usuario CdUsuarioNavigation { get; set; }
        public AcessoAcao IdAcessoAcaoNavigation { get; set; }
    }
}
