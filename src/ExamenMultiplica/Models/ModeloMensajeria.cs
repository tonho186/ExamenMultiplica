using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamenMultiplica.Models
{
    public class ModeloMensajeria
    {
        EntidadMensajeria entidad;

        public ModeloMensajeria()
        {
            this.entidad = new EntidadMensajeria();
        }

        public List<Vigencia> GetPedidos()
        {
            var consulta = from datos in entidad.Vigencia
                           select datos;
            return consulta.ToList();
        }

        public Vigencia BuscarPedido(int idpedido)
        {
            var consulta = from datos in entidad.Vigencia
                           where datos.Id == idpedido
                           select datos;
            return consulta.First();
        }

        public void AnyadirPedido(DateTime fechainicio, DateTime fechafin, int idUbigeo)
        {
            Vigencia p = new Models.Vigencia();
            p.FechaInicio = fechainicio;
            p.FechaFin = fechafin;
            p.idUbigeo = idUbigeo;

            this.entidad.Vigencia.Add(p);
            this.entidad.SaveChanges();
        }

        public void ModificarPedido(int idpedido, DateTime fechainicio, DateTime fechafin, int idUbigeo)
        {
            Vigencia p = this.BuscarPedido(idpedido);
            p.FechaInicio = fechainicio;
            p.FechaFin = fechafin;
            p.idUbigeo = idUbigeo;
            this.entidad.SaveChanges();
        }

        public void EliminarPedido(int idpedido)
        {
            Vigencia p = this.BuscarPedido(idpedido);
            this.entidad.Vigencia.Remove(p);
            this.entidad.SaveChanges();
        }
    }
}