using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class Mdfe
    {
        public Mdfe()
        {
            MdfeCondutor = new HashSet<MdfeCondutor>();
            MdfeDocumento = new HashSet<MdfeDocumento>();
            MdfeEvento = new HashSet<MdfeEvento>();
            MdfePercurso = new HashSet<MdfePercurso>();
        }

        public int CdFilial { get; set; }
        public int IdGeral { get; set; }
        public string CdModelo { get; set; }
        public string NrSerie { get; set; }
        public int NrMdf { get; set; }
        public int CdModalidade { get; set; }
        public DateTime DtEmissao { get; set; }
        public int TpEmitente { get; set; }
        public int TpEmissao { get; set; }
        public int CdCidadeCarregamento { get; set; }
        public string UfDescarregamento { get; set; }
        public int CdProprietarioVeiculo { get; set; }
        public int IdFornveic { get; set; }
        public int? QtCte { get; set; }
        public int? QtCt { get; set; }
        public int? QtNfe { get; set; }
        public int? QtNf { get; set; }
        public decimal? VlCarga { get; set; }
        public decimal? PesoBrutoCarga { get; set; }
        public int? CdStatusMdfe { get; set; }
        public string ChaveAcessoMdfe { get; set; }
        public string NrReciboMdfe { get; set; }
        public string NrProtocoloMdfe { get; set; }
        public string ArqXml { get; set; }
        public DateTime? DtAtz { get; set; }

        public Fornecedor Cd { get; set; }
        public Cidade CdCidadeCarregamentoNavigation { get; set; }
        public Filial CdFilialNavigation { get; set; }
        public ModeloDcto CdModeloNavigation { get; set; }
        public Fornveic Fornveic { get; set; }
        public NrSerieNfs NrSerieNavigation { get; set; }
        public ICollection<MdfeCondutor> MdfeCondutor { get; set; }
        public ICollection<MdfeDocumento> MdfeDocumento { get; set; }
        public ICollection<MdfeEvento> MdfeEvento { get; set; }
        public ICollection<MdfePercurso> MdfePercurso { get; set; }
    }
}
