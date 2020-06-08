namespace wsShalom
{
    using System.Web.Services;

    using System.Data;
    using ShalomApp.Domain.Entidades;
    using System;


    /// <summary>
    /// Descripción breve de wsShalom
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsShalom : System.Web.Services.WebService
    {
        Especialidad especialidad;
        Diagnostico diagnostico;
        Doctor doctor;
        MedNatural medNatural;
        Paramedico paramedico;
        Perfil perfil;
        Pantalla pantalla;
        Login login;
        Paciente paciente;
        HistMedico histMedico;
        DetalleCita detalleCita;
        Alerta alerta;
        Asignacion asignacion;

        [WebMethod]
        public string AgregaEspecialidad(string prDescripcion)
        {
            especialidad = new Especialidad()
            {
                Descripcion = prDescripcion
            };

            return especialidad.AgregaEspecialidad() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaEspecialidad()
        {
            especialidad = new Especialidad();
            return especialidad.ConsultaEspecialidades();
        }

        [WebMethod]
        public string ModificaEspecialidad(int prIdEspecialidad, string prDescripcion)
        {
            especialidad = new Especialidad()
            {
                IdEspecialidad = prIdEspecialidad,
                Descripcion = prDescripcion
            };

            return especialidad.ModificaEspecialidad() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaEspecialidad(int prIdEspecialidad)
        {
            especialidad = new Especialidad()
            {
                IdEspecialidad = prIdEspecialidad
            };

            return especialidad.EliminaEspecialidad() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaMedicinaNatural(int prIdDiagnostico, string prTratamiento, string prObservaciones)
        {
            medNatural = new MedNatural()
            {
                IdDiagnostico = prIdDiagnostico,
                Fecha = DateTime.Today,
                Tratamiento = prTratamiento,
                Observaciones = prObservaciones
            };

            return medNatural.AgregaMedicinaNatural() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaMedicinasNaturales()
        {
            medNatural = new MedNatural();
            return medNatural.ConsultaMedicinasNaturales();
        }

        [WebMethod]
        public DataSet ConsultaMedNaturalXDiagnostico(int prIdDiagnostico)
        {
            medNatural = new MedNatural()
            {
                IdDiagnostico = prIdDiagnostico
            };
            return medNatural.ConsultaMedNaturalXDiagnostico();
        }

        [WebMethod]
        public string ModificaMedNatural(int prIdMedNatural, int prIdDiagnostico, string prTratamiento, string prObservaciones)
        {
            medNatural = new MedNatural()
            {
                IdMedNatural = prIdMedNatural,
                IdDiagnostico = prIdDiagnostico,
                Tratamiento = prTratamiento,
                Observaciones = prObservaciones
            };

            return medNatural.ModificaMedNatural() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaMedNatural(int prIdMedNatural)
        {
            medNatural = new MedNatural()
            {
                IdMedNatural = prIdMedNatural
            };

            return medNatural.EliminaMedNatural() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaDiagnostico(string prDescripcion)
        {
            diagnostico = new Diagnostico()
            {
                Descripcion = prDescripcion
            };

            return diagnostico.AgregaDiagnostico() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaDiagnostico()
        {
            diagnostico = new Diagnostico();
            return diagnostico.ConsultaDiagnosticos();
        }

        [WebMethod]
        public string ModificaDiagnostico(int prIdDiagnostico, string prDescripcion)
        {
            diagnostico = new Diagnostico()
            {
                IdDiagnostico = prIdDiagnostico,
                Descripcion = prDescripcion
            };

            return diagnostico.ModificaDiagnostico() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaDiagnostico(int prIdDiagnostico)
        {
            diagnostico = new Diagnostico()
            {
                IdDiagnostico = prIdDiagnostico
            };

            return diagnostico.EliminaDiagnostico() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaDoctor(int prColegiado, int prIdEspecialidad, string prNombre, string prApellido)
        {
            doctor = new Doctor()
            {
                IdDoctor = prColegiado,
                IdEspecialidad = prIdEspecialidad,
                Nombre = prNombre,
                Apellido = prApellido
            };

            return doctor.AgregaDoctor() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaDoctor()
        {
            doctor = new Doctor();
            return doctor.ConsultaDoctores();
        }

        [WebMethod]
        public string ModificaDoctor(int prIdDoctor, int prIdEspecialidad, string prNombre, string prApellido)
        {
            doctor = new Doctor()
            {
                IdDoctor = prIdDoctor,
                IdEspecialidad = prIdEspecialidad,
                Nombre = prNombre,
                Apellido = prApellido
            };

            return doctor.ModificaDoctor() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaDoctor(int prIdDoctor)
        {
            doctor = new Doctor()
            {
                IdDoctor = prIdDoctor
            };

            return doctor.EliminaDoctor() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaParamedico(string prDocumento, string prNombre, string prApellido, string prNivelExpertise)
        {
            paramedico = new Paramedico()
            {
                Documento = prDocumento,
                Nombre = prNombre,
                Apellido = prApellido,
                FechaIngreso = DateTime.Today,
                NivelExpertise = prNivelExpertise
            };

            return paramedico.AgregaParamedico() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaParamedico()
        {
            paramedico = new Paramedico();
            return paramedico.ConsultaParamedicos();
        }

        [WebMethod]
        public string ModificaParamedico(int prIdParamedico, string prDocumento, string prNombre, string prApellido, string prNivelExpertise)
        {
            paramedico = new Paramedico()
            {
                IdParamedico = prIdParamedico,
                Documento = prDocumento,
                Nombre = prNombre,
                Apellido = prApellido,
                NivelExpertise = prNivelExpertise
            };

            return paramedico.ModificaParamedico() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaParamedico(int prIdParamedico)
        {
            paramedico = new Paramedico()
            {
                IdParamedico = prIdParamedico
            };

            return paramedico.EliminaParamedico() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaPerfil(string prDescripcion)
        {
            perfil = new Perfil()
            {
                Descripcion = prDescripcion
            };

            return perfil.AgregaPerfil() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaPerfil()
        {
            perfil = new Perfil();
            return perfil.ConsultaPerfiles();
        }

        [WebMethod]
        public string ModificaPerfil(int prIdPerfil, string prDescripcion)
        {
            perfil = new Perfil()
            {
                IdPerfil = prIdPerfil,
                Descripcion = prDescripcion
            };

            return perfil.ModificaPerfil() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaPerfil(int prIdPerfil)
        {
            perfil = new Perfil()
            {
                IdPerfil = prIdPerfil
            };

            return perfil.EliminaPerfil() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaPantalla(int prIdPerfil, string prNombrePantalla)
        {
            pantalla = new Pantalla()
            {
                IdPerfil = prIdPerfil,
                NombrePantalla = prNombrePantalla
            };

            return pantalla.AgregaPantalla() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaPantalla()
        {
            pantalla = new Pantalla();
            return pantalla.ConsultaPantallas();
        }

        [WebMethod]
        public DataSet ConsultaPantallaXPerfil(int prIdPerfil)
        {
            pantalla = new Pantalla()
            {
                IdPerfil = prIdPerfil
            };
            return pantalla.ConsultaPantallaXPerfil();
        }

        [WebMethod]
        public string ModificaPantalla(int prIdPantalla, int prIdPerfil, string prNombrePantalla)
        {
            pantalla = new Pantalla()
            {
                IdPantalla = prIdPantalla,
                IdPerfil = prIdPerfil,
                NombrePantalla= prNombrePantalla
            };

            return pantalla.ModificaPantalla() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaPantalla(int prIdPantalla)
        {
            pantalla = new Pantalla()
            {
                IdPantalla = prIdPantalla
            };

            return pantalla.EliminaPantalla() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaLogin(int prTipo, string prAlias, string prPassword, int prIdPerfil, int prIdPaciente, int prIdDoctor, int prIdParamedico)
        {
            login = new Login()
            {
                IdPerfil = prIdPerfil,
                Alias = prAlias,
                Password = prPassword,
                IdPaciente = prIdPaciente,
                IdDoctor = prIdDoctor,
                IdParamedico = prIdParamedico
            };

            return login.AgregaLogin(prTipo) ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaLogins()
        {
            login = new Login();
            return login.ConsultaLogins();
        }

        [WebMethod]
        public DataSet ConsultaLogin(string prAlias, string prPassword)
        {
            login = new Login()
            {
                Alias = prAlias,
                Password = prPassword
            };
            return login.ConsultaLogin();
        }

        [WebMethod]
        public string ModificaLogin(int prIdLogin, string prAlias, string prPassword, int prIdPerfil, int prIdPaciente, int prIdDoctor, int prIdParamedico)
        {
            login = new Login()
            {
                IdLogin = prIdLogin,
                IdPerfil = prIdPerfil,
                Alias = prAlias,
                Password = prPassword,
                IdPaciente = prIdPaciente,
                IdDoctor = prIdDoctor,
                IdParamedico = prIdParamedico
            };

            return login.ModificaLogin() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaLogin(int prIdLogin)
        {
            login = new Login()
            {
                IdLogin = prIdLogin
            };

            return login.EliminaLogin() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaPaciente(string prDocumento, string prNombre, string prApellido, int prAnio, int prMes, int prDia)
        {
            paciente = new Paciente()
            {
                Documento = prDocumento,
                Nombre = prNombre,
                Apellido = prApellido,
                FechaNacimiento = new DateTime(prAnio, prMes, prDia),
                FechaIngreso = DateTime.Today
            };

            return paciente.AgregaPaciente() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public string AgregaPacienteMenor(string prNombre, string prApellido, int prAnio, int prMes, int prDia, int prIdResponsable)
        {
            paciente = new Paciente()
            {
                Nombre = prNombre,
                Apellido = prApellido,
                FechaNacimiento = new DateTime(prAnio, prMes, prDia),
                FechaIngreso = DateTime.Today,
                IdResponsable = prIdResponsable
            };

            return paciente.AgregaPacienteMenor() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaPacientes()
        {
            paciente = new Paciente();
            return paciente.ConsultaPacientes();
        }

        [WebMethod]
        public DataSet ConsultaPacienteXDPI(string prDPI)
        {
            paciente = new Paciente()
            {
                Documento = prDPI
            };
            return paciente.ConsultaPacienteXDPI();
        }

        [WebMethod]
        public DataSet ConsultaPacienteXId(int prIdPaciente)
        {
            paciente = new Paciente()
            {
                IdPaciente = prIdPaciente
            };
            return paciente.ConsultaPacienteXId();
        }

        [WebMethod]
        public DataSet ConsultaPacienteXNombre(string prNombre, string prApellido)
        {
            paciente = new Paciente()
            {
                Nombre = prNombre,
                Apellido = prApellido
            };
            return paciente.ConsultaPacienteXNombre();
        }

        [WebMethod]
        public string ModificaPaciente(int prIdPaciente, string prDocumento, string prNombre, string prApellido, int prAnio, int prMes, int prDia)
        {
            paciente = new Paciente()
            {
                IdPaciente = prIdPaciente,
                Documento = prDocumento,
                Nombre = prNombre,
                Apellido = prApellido,
                FechaNacimiento = new DateTime(prAnio, prMes, prDia)
            };

            return paciente.ModificaPaciente() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string ModificaPacienteMenor(int prIdPaciente, string prNombre, string prApellido, int prAnio, int prMes, int prDia, int prIdResponsable)
        {
            paciente = new Paciente()
            {
                IdPaciente = prIdPaciente,
                Nombre = prNombre,
                Apellido = prApellido,
                FechaNacimiento = new DateTime(prAnio, prMes, prDia),
                IdResponsable = prIdResponsable
            };

            return paciente.ModificaPacienteMenor() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string EliminaPaciente(int prIdPaciente)
        {
            paciente = new Paciente()
            {
                IdPaciente = prIdPaciente
            };

            return paciente.EliminaPaciente() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }

        [WebMethod]
        public string AgregaHistMedico(string prTipoHist, int prIdPaciente)
        {
            histMedico = new HistMedico()
            {
                TipoHist = prTipoHist,
                Fecha = DateTime.Today,
                Hora = DateTime.Now,
                IdPaciente = prIdPaciente
            };

            object ultimoId = histMedico.AgregaHistMedico();

            return (ultimoId!=null) ? ultimoId.ToString() : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaHistMedico()
        {
            histMedico = new HistMedico();
            return histMedico.ConsultaHistMedico();
        }

        [WebMethod]
        public DataSet ConsultaHistMedicoXFechas(int prAnioI, int prMesI, int prDiaI, int prAnioF, int prMesF, int prDiaF)
        {
            histMedico = new HistMedico()
            {
                FechaInicial = new DateTime(prAnioI, prMesI, prDiaI),
                FechaFinal = new DateTime(prAnioF, prMesF, prDiaF)
            };
            return histMedico.ConsultaHistMedicoXFechas();
        }

        [WebMethod]
        public DataSet ConsultaHistMedicoXId(int prIdCita)
        {
            histMedico = new HistMedico()
            {
                IdCita = prIdCita
            };
            return histMedico.ConsultaHistMedicoXId();
        }

        [WebMethod]
        public string AgregaDetalleCita(int prIdCita, int prIdDoctor, int prIdDiagnostico, string prSintomas, string prTratamiento)
        {
            detalleCita = new DetalleCita()
            {
                IdCita = prIdCita,
                IdDoctor = prIdDoctor,
                IdDiagnostico = prIdDiagnostico,
                Sintomas = prSintomas,
                Tratamiento = prTratamiento
            };

            return detalleCita.AgregaDetalleCita() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public string ModificaDetalleCita(int prIdDetalleCita, int prIdDoctor, int prIdDiagnostico, string prSintomas, string prTratamiento)
        {
            detalleCita = new DetalleCita()
            {
                IdDetalleCita = prIdDetalleCita,
                IdDoctor = prIdDoctor,
                IdDiagnostico = prIdDiagnostico,
                Sintomas = prSintomas,
                Tratamiento = prTratamiento
            };

            return detalleCita.ModificaDetalleCita() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string AgregaAlerta(int prIdCita, string prSintomas, string prTratamiento, int prUPaciente)
        {
            alerta = new Alerta()
            {
                IdCita = prIdCita,
                Sintomas = prSintomas,
                Tratamiento = prTratamiento,
                UPaciente = prUPaciente
            };

            return alerta.AgregaAlerta() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaAlertasPendientes()
        {
            alerta = new Alerta();
            return alerta.ConsultaAlertasPendientes();
        }

        [WebMethod]
        public DataSet ConsultaAlertasXParamedico(int prIdParamedico)
        {
            alerta = new Alerta()
            {
                IdParamedico = prIdParamedico
            };
            return alerta.ConsultaAlertasXParamedico();
        }

        [WebMethod]
        public DataSet ConsultaAlertaXId(int prIdAlerta)
        {
            alerta = new Alerta()
            {
                IdAlerta = prIdAlerta
            };
            return alerta.ConsultaAlertaXId();
        }

        [WebMethod]
        public string ModificaAlertaAtendido(int prIdAlerta, string prSintomas, string prTratamiento)
        {
            alerta = new Alerta()
            {
                IdAlerta = prIdAlerta,
                Sintomas = prSintomas,
                Tratamiento = prTratamiento
            };

            return alerta.ModificaAlertaAtendido() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string ModificaAlertaEnCurso(int prIdAlerta, int prIdParamedico, int prUParamedico)
        {
            alerta = new Alerta()
            {
                IdAlerta = prIdAlerta,
                IdParamedico = prIdParamedico,
                UParamedico = prUParamedico
            };

            return alerta.ModificaAlertaEnCurso() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string ModificaAlertaUParamedico(int prIdAlerta, int prUParamedico)
        {
            alerta = new Alerta()
            {
                IdAlerta = prIdAlerta,
                UParamedico = prUParamedico
            };

            return alerta.ModificaAlertaUParamedico() ? "modificado correctamente" : "algo salió mal en la modificación";
        }

        [WebMethod]
        public string AgregaAsignacion(int prIdPaciente, int prIdDoctor)
        {
            asignacion = new Asignacion()
            {
                IdPaciente = prIdPaciente,
                IdDoctor = prIdDoctor
            };

            return asignacion.AgregaAsignacion() ? "agregado correctamente" : "algo salió mal en la inserción";
        }

        [WebMethod]
        public DataSet ConsultaAsignaciones()
        {
            asignacion = new Asignacion();
            return asignacion.ConsultaAsignaciones();
        }

        [WebMethod]
        public DataSet ConsultaAsignacion(int prIdPaciente, int prIdDoctor)
        {
            asignacion = new Asignacion()
            {
                IdPaciente = prIdPaciente,
                IdDoctor = prIdDoctor
            };
            return asignacion.ConsultaAsignacion();
        }

        [WebMethod]
        public string EliminaAsignacion(int prIdPaciente, int prIdDoctor)
        {
            asignacion = new Asignacion()
            {
                IdPaciente = prIdPaciente,
                IdDoctor = prIdDoctor
            };

            return asignacion.EliminaAsignacion() ? "eliminado correctamente" : "algo salió mal en la eliminación";
        }
    }
}
