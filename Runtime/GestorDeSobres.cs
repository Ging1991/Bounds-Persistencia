using System.Collections.Generic;
using Bounds.Persistencia.Datos;
using Bounds.Persistencia.Lectores;
using Ging1991.Dialogos.Persistencia;

namespace Bounds.Persistencia {

	public class GestorDeSobres {

		private readonly LectorSobres lector;

		public GestorDeSobres(string direccion) {
			lector = new(direccion);
			if (!lector.ExistenDatos()) {
				LectorLista<SobreBD>.DatoBD<SobreBD> datoBD = new() {
					lista = new List<SobreBD>()
				};
				lector.Guardar(datoBD);
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
				List<SobreBD> datoLista = lector.GetLista();
				sobre = new() {
					nombre = coleccion,
					cantidad = 0
				};
				datoLista.Add(sobre);
				lector.Guardar();
			}
		}


		private void EliminarSobreSiEstaVacio(string coleccion) {
			SobreBD sobre = lector.GetSobre(coleccion);
			if (sobre != null && sobre.cantidad == 0) {
				List<SobreBD> datoLista = lector.GetLista();
				datoLista.Remove(sobre);
				lector.Guardar();
			}
		}


	}

}