using Bounds.Persistencia.Datos;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Persistencia.Lectores {

	public class LectorSobres : LectorGenerico<ListaDato<SobreBD>> {

		public LectorSobres(string direccion) : base(direccion, TipoLector.DINAMICO) { }

		public SobreBD GetSobre(string coleccion) {
			SobreBD ret = null;
			foreach (var dato in Leer().lista) {
				if (dato.nombre == coleccion)
					ret = dato;
			}
			return ret;
		}

	}

}