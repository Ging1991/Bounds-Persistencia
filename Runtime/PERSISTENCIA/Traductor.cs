using System.Collections.Generic;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Modulos.Persistencia {

	public class TraductorCartaID : ISelectorXXX<int, string> {

		private readonly Dictionary<int, string> datos;

		public TraductorCartaID(string direccion) {
			LectorMapa<int, string> lector = new(direccion, TipoLector.RECURSOS);
			datos = lector.LeerMapa();
		}

		public string GetElemento(int clave) {
			if (datos.ContainsKey(clave)) {
				return datos[clave];
			}
			return null;
		}

	}

}