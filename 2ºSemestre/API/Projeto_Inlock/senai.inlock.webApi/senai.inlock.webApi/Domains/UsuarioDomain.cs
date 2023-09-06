namespace senai.inlock.webApi_.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }
        public string IdTipoUsuario { get; set; }
        public TipoUsuarioDomain tipoUsuario { get; set; }
        public string EmailUsuario { get; set; }
        public string SenhaUsuario { get; set; }
    }
}
