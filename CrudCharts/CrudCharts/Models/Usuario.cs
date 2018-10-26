using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            AcessoAcaoUsuario = new HashSet<AcessoAcaoUsuario>();
            OrcamentoC = new HashSet<OrcamentoC>();
            UsuarioPerfil = new HashSet<UsuarioPerfil>();
        }

        public int CdUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string FlAcessoIrrestrito { get; set; }
        public string FlAtivo { get; set; }
        public string FlCtrlCxaRetaguarda { get; set; }
        public string FlCtrlFilial { get; set; }
        public int? CdFuncionario { get; set; }
        public string FlSessaoDifInstalacao { get; set; }

        public ICollection<AcessoAcaoUsuario> AcessoAcaoUsuario { get; set; }
        public ICollection<OrcamentoC> OrcamentoC { get; set; }
        public ICollection<UsuarioPerfil> UsuarioPerfil { get; set; }
    }
}
