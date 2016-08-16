using System.Collections.Generic;

namespace WebBooks.DataAccess
{
    public interface IDataAccess<T>
    {
        List<T> ObtenerLista();
        int Agregar(T Entity);
        int Eliminar(T Entity);
        int Actualizar(T Entity);
        int CantidadTotal();
    }
}
