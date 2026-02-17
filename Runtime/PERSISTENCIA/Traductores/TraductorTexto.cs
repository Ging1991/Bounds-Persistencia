using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Modulos.Persistencia {

	public class TraductorTexto : ISelector<string, string> {

		private readonly Dictionary<string, string> datos;

		public TraductorTexto(string direccion) {
			LectorMapa<string, string> lector = new(direccion, TipoLector.RECURSOS);
			datos = lector.LeerMapa();
		}

		public string GetElemento(string clave) {
			if (datos.ContainsKey(clave)) {
				return datos[clave];
			}
			return null;
		}

	}

}