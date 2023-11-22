using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Dominio
{
    public class Comprobante
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public FormaPago FormaPago { get; set; }
        public List<DetalleComprobante> DetsComprobante { get; set; }
        public int CantEntradas { get; set; }
        public double? PrecioTotal { get; set; }

        public Comprobante()
        {
            DetsComprobante = new List<DetalleComprobante>();            
        }

        public void AgregarDetalle(DetalleComprobante det)
        {
            DetsComprobante.Add(det);
        }

        public void QuitarDetalle(DetalleComprobante det)
        {
            DetsComprobante.Remove(det);
        }
    }
}
