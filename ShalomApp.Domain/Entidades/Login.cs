namespace ShalomApp.Domain.Entidades
{
    public class Login
    {
        public int IdLogin { get; set; }
        public string Alias { get; set; }
        public string Pasword { get; set; }
        public int IdPerfil { get; set; }
        public int IdParamedico { get; set; }
        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }
    }
}
