using CineBack.Datos;
using CineBack.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Servicios.Interfaz
{
    public interface IServicio
    {
        public List<Barrio> CargarBarrios(string nombreSP);
        public List<TipoCliente> CargarTiposClientes(string nombreSP);
        public Cliente CargarCliente(List<Parametro> lParams);









        public List<Funcion> CargarFunciones(string nombreSP);
        public List<FormaPago> CargarFormasPago(string nombreSP);
        
        
        
        public List<Butaca> CargarButacas(List<Parametro> lParams);
        
        
        
        
        
        
        public bool SaveCliente(Cliente oC);
        public bool SaveComprobante(Comprobante oC);

        public List<Cliente> CargarClientes(List<Parametro> lParams);
        public bool ModificarCliente(Cliente oC);
        public bool ActualizarButaca(Comprobante oC);

        public bool DeleteCliente(int id);
        public Comprobante CargarComprobante(List<Parametro> lParams);
        public bool ActualizarComprobante(Comprobante oC);
        public List<Comprobante> CargarComprobantes(List<Parametro> lParams);
    }
}
