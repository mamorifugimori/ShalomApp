namespace ShalomApp.Domain.Entidades
{
    using Datos;
    using System.Data;

    public class Login
    {
        Insertar inserciones;
        Consultar consultas;
        Modificar modificaciones;
        Eliminar eliminaciones;

        public int IdLogin { get; set; }
        public string Alias { get; set; }
        public string Password { get; set; }
        public int IdPerfil { get; set; }
        public int IdParamedico { get; set; }
        public int IdDoctor { get; set; }
        public int IdPaciente { get; set; }

        public DataSet ConsultaLogins()
        {
            consultas = new Consultar();
            return consultas.ObtenerLogins();
        }

        public DataSet ConsultaLogin()
        {
            consultas = new Consultar();
            return consultas.ObtenerLogin(Alias, Password);
        }

        public bool AgregaLogin(int login)
        {
            inserciones = new Insertar();
            if(login==1)
                return inserciones.AgregarLoginPaciente(IdPerfil,Alias,Password,IdPaciente);
            else if(login==2)
                return inserciones.AgregarLoginDoctor(IdPerfil, Alias, Password, IdDoctor);
            else if(login==3)
                return inserciones.AgregarLoginParamedico(IdPerfil, Alias, Password, IdParamedico);
            return false;
        }

        public bool ModificaLogin()
        {
            modificaciones = new Modificar();
            return modificaciones.ModificarLogin(IdLogin, IdPerfil, Alias, Password, IdParamedico, IdDoctor, IdPaciente);
        }

        public bool EliminaLogin()
        {
            eliminaciones = new Eliminar();
            return eliminaciones.EliminarLogin(IdLogin);
        }
    }
}
