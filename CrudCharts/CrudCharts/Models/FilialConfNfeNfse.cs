using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class FilialConfNfeNfse
    {
        public int CdFilial { get; set; }
        public string CertificadoCaminho { get; set; }
        public string CertificadoSenha { get; set; }
        public string CertificadoNumeroSerie { get; set; }
        public string PathSchemaNfse { get; set; }
        public string PathXmlNfse { get; set; }
        public string TpAmbienteNfse { get; set; }
        public int? RegimeEspecialTribNfse { get; set; }
        public int? TempoEsperaConsulta { get; set; }
        public int? Tentativas { get; set; }
        public string PathSchemaNfe { get; set; }
        public string PathXmlNfe { get; set; }
        public string TpAmbienteNfe { get; set; }
        public bool? Visualizar { get; set; }
        public string Logoprefeitura { get; set; }
        public string Logonfe { get; set; }
        public string VersaoNfe { get; set; }
        public string PathXmlMdfe { get; set; }
        public string PathSchemaMdfe { get; set; }
        public string TpAmbienteMdfe { get; set; }
        public string SenhaWebserv { get; set; }
        public string UsuarioWebserv { get; set; }
        public string FlEnviaEmail { get; set; }
        public string EmailNfe { get; set; }
        public string Csc { get; set; }
        public string IdCsc { get; set; }
    }
}
