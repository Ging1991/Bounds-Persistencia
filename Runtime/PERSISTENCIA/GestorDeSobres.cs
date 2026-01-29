using Bounds.Persistencia.Datos;
using Bounds.Persistencia.Lectores;

namespace Bounds.Persistencia {

	public class GestorDeSobres {

		private readonly LectorSobres lector;

		public GestorDeSobres(string direccion) {
			lector = new(direccion);
			if (!lector.ExistenDatos()) {
				lector.Guardar(new ListaDato<SobreBD>());
			}
		}


		public int GetCantidad(string coleccion) {
			SobreBD dato = lector.GetSobre(coleccion);
			if (dato != null) {
				return dato.cantidad;
			}
			return 0;
		}


		public void SetCantidad(string coleccion, int cantidad) {
			CrearSobreSiNoExiste(coleccion);
			SobreBD sobre = lector.GetSobre(coleccion);
			sobre.cantidad = cantidad;
			lector.Guardar();
			EliminarSobreSiEstaVacio(coleccion);
		}


		private void CrearSobreSiNoExiste(string coleccion) {
			SobreBD sobre = lector.GetSobre(coleccion);
			if (sobre == null) {
				ListaDato<SobreBD> datoLista = lector.Leer();
				sobre = new() {
					nombre = coleccion,
					cantidad = 0
				};
				datoLista.lista.Add(sobre);
				lector.Guardar(datoLista);
			}
		}


		private void EliminarSobreSiEstaVacio(string coleccion) {
			SobreBD sobre = lector.GetSobre(coleccion);
			if (sobre != null && sobre.cantidad == 0) {
				ListaDato<SobreBD> datoLista = lector.Leer();
				datoLista.lista.Remove(sobre);
				lector.Guardar(datoLista);
			}
		}


	}

}