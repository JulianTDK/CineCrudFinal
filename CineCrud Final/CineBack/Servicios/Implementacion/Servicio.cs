using CineBack.Datos;
using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Dominio;
using CineBack.Servicios.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Servicios.Implementacion
{
    internal class Servicio : IServicio
    {
        private ICineDao dao;

        public Servicio()
        {
            dao = new CineDao();
        }

        public List<Barrio> CargarBarrios(string nombreSP)
        {
            return dao.CargarBarrios(nombreSP);
        }

        public List<TipoCliente> CargarTiposClientes(string nombreSP)
        {
            return dao.CargarTiposClientes(nombreSP);
        }

        public Cliente CargarCliente(List<Parametro> lParams)
        {
            return dao.CargarCliente(lParams);
        }

        public List<Funcion> CargarFunciones(string nombreSP)
        {
            return dao.CargarFunciones(nombreSP);
        }

        public List<FormaPago> CargarFormasPago(string nombreSP)
        {
            return dao.CargarFormasPago(nombreSP);
        }

        
        
        
        public List<Butaca> CargarButacas(List<Parametro> lParams)
        {
            return dao.CargarButacas(lParams);
        }
        

        
        
        
        
        
        
        
        
        
        
        
        
        public bool SaveCliente(Cliente oC)
        {
            return dao.SaveCliente(oC);
        }

        public bool SaveComprobante(Comprobante oC)
        {
            return dao.SaveComprobante(oC);
        }

        public List<Cliente> CargarClientes(List<Parametro> lParams)
        {
            return dao.CargarClientes(lParams);
        }

        public bool ModificarCliente(Cliente oC)
        {
            return dao.ModificarCliente(oC);
        }

        public bool ActualizarButaca(Comprobante oC)
        {
            return dao.ActualizarButaca(oC);
        }

        public bool DeleteCliente(int id)
        {
            return dao.DeleteCliente(id);
        }

        public Comprobante CargarComprobante(List<Parametro> lParams)
        {
            return dao.CargarComprobante(lParams);
        }

        public bool ActualizarComprobante(Comprobante oC)
        {
            return dao.ActualizarComprobante(oC);
        }

        public List<Comprobante> CargarComprobantes(List<Parametro> lParams)
        {
            return dao.CargarComprobantes(lParams);
        }
    }
}
