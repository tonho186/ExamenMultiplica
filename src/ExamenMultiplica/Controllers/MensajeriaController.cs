using ExamenMultiplica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExamenMultiplica.Controllers
{
    public class MensajeriaController : ApiController
    {
        ModeloMensajeria modelo;

        public MensajeriaController()
        {
            this.modelo = new ModeloMensajeria();
        }

        // GET: api/Mensajeria
        public List<Vigencia> GetPedidos()
        {
            return this.modelo.GetPedidos();
        }

        // GET: api/Mensajeria/5
        public Vigencia GetPedido(int id)
        {
            return this.modelo.BuscarPedido(id);
        }

        // POST: api/Mensajeria
        public void Post(Vigencia p)
        {
            this.modelo.AnyadirPedido((DateTime)p.FechaInicio, (DateTime)p.FechaFin, (int)p.idUbigeo);
        }

        // PUT: api/Mensajeria/5
        public void Put(int id, Vigencia p)
        {
            this.modelo.ModificarPedido(id, (DateTime)p.FechaInicio, (DateTime)p.FechaFin, (int)p.idUbigeo);
        }

        // DELETE: api/Mensajeria/5
        public void Delete(int id)
        {
            this.modelo.EliminarPedido(id);
        }
    }
}
