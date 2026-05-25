using UnityEngine;

namespace Bounds.Persistencia.Parametros {

	public abstract class ParametrosControl : MonoBehaviour {

		public ParametrosEscena parametros;

		public void Inicializar() {
			if (parametros.inicializado == false) {
				parametros.Inicializar();
				SetParametros();
				parametros.inicializado = true;
			}
		}

		public abstract void SetParametros();

	}

}