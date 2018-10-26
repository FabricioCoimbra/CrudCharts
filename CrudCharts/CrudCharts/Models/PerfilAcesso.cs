using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class PerfilAcesso
    {
        public PerfilAcesso()
        {
            AcessoAcaoPerfil = new HashSet<AcessoAcaoPerfil>();
            UsuarioPerfil = new HashSet<UsuarioPerfil>();
        }

        public int CdPerfil { get; set; }
        public string NmPerfil { get; set; }
        public string FlAcessoIrrestrito { get; set; }
        public string FlAtivo { get; set; }

        public ICollection<AcessoAcaoPerfil> AcessoAcaoPerfil { get; set; }
        public ICollection<UsuarioPerfil> UsuarioPerfil { get; set; }
    }
}
