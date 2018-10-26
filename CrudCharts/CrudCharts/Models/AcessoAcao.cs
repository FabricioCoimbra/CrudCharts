using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class AcessoAcao
    {
        public AcessoAcao()
        {
            AcessoAcaoPerfil = new HashSet<AcessoAcaoPerfil>();
            AcessoAcaoRelCampo = new HashSet<AcessoAcaoRelCampo>();
            AcessoAcaoUsuario = new HashSet<AcessoAcaoUsuario>();
            Consulta = new HashSet<Consulta>();
        }

        public long IdGeral { get; set; }
        public string CdAcesso { get; set; }
        public string NmAcao { get; set; }
        public string NmProcedimento { get; set; }
        public string FlClassificacao { get; set; }
        public string Obs { get; set; }
        public string FlAlterar { get; set; }
        public string FlInserir { get; set; }
        public string FlExcluir { get; set; }
        public string FlPermitirFilial { get; set; }
        public int? CdConexao { get; set; }
        public int? TpEmpresa { get; set; }

        public AcessoAcaoRelatorio AcessoAcaoRelatorio { get; set; }
        public ICollection<AcessoAcaoPerfil> AcessoAcaoPerfil { get; set; }
        public ICollection<AcessoAcaoRelCampo> AcessoAcaoRelCampo { get; set; }
        public ICollection<AcessoAcaoUsuario> AcessoAcaoUsuario { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
