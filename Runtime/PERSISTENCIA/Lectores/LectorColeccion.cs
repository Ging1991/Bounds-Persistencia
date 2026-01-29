using Bounds.Persistencia.Datos;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Persistencia.Lectores {

	public class LectorColeccion : LectorGenerico<ColeccionBD> {

		public LectorColeccion(string direccion) : base(direccion, TipoLector.RECURSOS) { }

	}

}