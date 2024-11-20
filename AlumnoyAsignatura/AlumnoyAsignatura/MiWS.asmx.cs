using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AlumnoyAsignatura
{
    /// <summary>
    /// Descripción breve de MiWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MiWS : System.Web.Services.WebService
    {

        [WebMethod]
        public bool GuardarAlumn(string nombre, string apellidopat, string apellidomat, string email, string numeromatri)
        {
            try
            {
                Trabajo2_RemotoEntities2 ctx = new Trabajo2_RemotoEntities2();
                Alumno alumno = new Alumno();
                alumno.Nombre = nombre;
                alumno.ApellidoPAt = apellidopat;
                alumno.ApellidoMat = apellidomat;
                alumno.Email = email;
                alumno.NumeroMatricula = numeromatri;
                ctx.Alumno.Add(alumno);
                ctx.SaveChanges();
                //si es
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        [WebMethod]
        public bool GuardarAsig(string nombreasig, int creditos)
        {
            try
            {
                using (Trabajo2_RemotoEntities2 ctx = new Trabajo2_RemotoEntities2())
                {
                    // Crear una nueva asignatura
                    Asignatura nuevaAsignatura = new Asignatura
                    {
                        NombreAsignatura = nombreasig,
                        Creditos = creditos
                    };

                    // Agregar la asignatura al DbSet
                    ctx.Asignatura.Add(nuevaAsignatura);

                    // Guardar los cambios
                    ctx.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en GuardarAsig: {ex.Message}");
                return false;
            }
        }

        [WebMethod]
        public List<Alumno> Listaralumno()
        {
            Trabajo2_RemotoEntities2 ctx = new Trabajo2_RemotoEntities2();
            return ctx.Alumno.ToList();
        }
        [WebMethod]
        public List<Asignatura> Listarasignatura()
        {
            try
            {
                using (Trabajo2_RemotoEntities2 ctx = new Trabajo2_RemotoEntities2())
                {
                    var asignaturas = ctx.Asignatura.ToList();
                    System.Diagnostics.Debug.WriteLine($"Asignaturas encontradas: {asignaturas.Count}");
                    return asignaturas;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error en Listarasignatura: {ex.Message}");
                return new List<Asignatura>();
            }
        }
    }
}
