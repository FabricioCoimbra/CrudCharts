using System;
using System.Collections.Generic;

namespace CrudCharts.Models
{
    public partial class UsuarioPerfil
    {
        public int CdUsuario { get; set; }
        public int CdPerfil { get; set; }

        public PerfilAcesso CdPerfilNavigation { get; set; }
        public Usuario CdUsuarioNavigation { get; set; }
    }
}
