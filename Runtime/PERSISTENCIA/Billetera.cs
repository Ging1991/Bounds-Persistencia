using Ging1991.Persistencia.Lectores;
using Ging1991.Persistencia.Lectores.Directos;

namespace Bounds.Persistencia {

	public class Billetera {

		private readonly LectorEntero lector;
		private readonly int ORO_INICIAL = 10000;

		public Billetera(string direccion) {
			lector = new(direccion, TipoLector.DINAMICO);
			if (!lector.ExistenDatos()) {
				lector.Guardar(ORO_INICIAL);
			}
		}


		public bool GastarOro(int cantidad) {
			int cantidadActual = lector.Leer().valor;
			if (cantidadActual < cantidad)
				return false;
			lector.Leer().valor -= cantidad;
			lector.Guardar();
			return true;
		}


		public void GanarOro(int cantidad) {
			lector.Leer().valor += cantidad;
			lector.Guardar();
		}


		public int LeerOro() {
			return lector.Leer().valor;
		}


	}

}