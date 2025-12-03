using CapaAccesoDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdensalida
    {
        #region singleton
        private static readonly logOrdensalida _instancia = new logOrdensalida();
        public static logOrdensalida Instancia => _instancia;
        #endregion

        #region Métodos de Negocio

        // Listado para la bandeja
        public List<entOrdensalida> ListarOrdensalida(string num, int? obraId, DateTime? desde, DateTime? hasta)
        {
            return datOrdensalida.Instancia.ListarOrdensalida(num, obraId, desde, hasta);
        }

        // Validación y obtención de Material
        public entMaterial ValidarYBuscarMaterial(string codigo, decimal cantidadRequerida)
        {
            entMaterial m = datOrdensalida.Instancia.BuscarMaterialPorCodigo(codigo);

            if (m == null)
            {
                throw new Exception("Error: El código de material no existe o está inactivo.");
            }

            if (m.Stock < cantidadRequerida)
            {
                // Devolvemos el stock disponible en el mensaje de error
                throw new Exception($"Error: Stock insuficiente. Solo hay {m.Stock:0.##} {m.UnidadMedida} disponibles.");
            }

            return m; // Devuelve el objeto completo para usar en el detalle
        }

        // Inserción de la orden (transacción)
        public int InsertarOrdensalida(entOrdensalida os)
        {
            // Aquí puedes agregar validaciones de cabecera (ObraID válido, Numero no nulo, etc.)
            return datOrdensalida.Instancia.RegistrarOrdensalida(os);
        }

        // Anulación de la orden (transacción)
        public void AnularOrdensalida(entOrdensalida os)
        {
            // Se asume que el estado de la OS es 'Registrado' o similar para poder anular.
            // La lógica de anulación y reversión de stock está en la Capa de Datos/SQL.
            datOrdensalida.Instancia.AnularOrdensalida(os);
        }

        #endregion
    }
}
