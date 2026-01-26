using System.Collections.Generic;

namespace Bounds.Persistencia {

	public class ParametrosBounds {

		private readonly Dictionary<string, string> direcciones;

		public ParametrosBounds() {
			direcciones = new();
		}

		public void SetDireccion(string clave, string valor) {
			direcciones[clave] = valor;
		}

		public string GetDireccion(string clave) {
			return direcciones[clave];
		}

	}

}