using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class ParametrosControl : MonoBehaviour {

		public ParametrosEscena parametros;

		public void Inicializar() {
			if (parametros.inicializado == false) {
				parametros.Inicializar();
				parametros.SetDireccion("DIRECCION_NOMBRES", new DireccionRecursos("Nombres", "Nombres").Generar());
			}
		}

	}
}
