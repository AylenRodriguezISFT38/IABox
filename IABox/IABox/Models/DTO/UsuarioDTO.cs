namespace IABox.Models.DTO
{
    public partial class UsuarioDTO
    {
        public long UsrId { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string idEmpresa { get; set; }
        public string Empresa { get; set; }
        public string EmpresaImg { get; set; }
        public virtual List<string> Permission { get; set; }

        public SiteDTO Site { get; set; }
        public string PantallaDefault { get; set; }
        public string PcId { get; set; }
    }
}