using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class NfXml
    {
        public int IdNf { get; set; }
        public char FlEntSai { get; set; }
        public string Xml { get; set; }
        public DateTime? DtAtz { get; set; }
        public string XmlCanc { get; set; }
    }
}
