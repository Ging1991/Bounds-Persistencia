using Bounds.Modulos.Persistencia;
using Ging1991.Interfaces.Personalizacion;
using UnityEngine;

namespace Bounds.Persistencia {

	public class ControlUIBounds : MonoBehaviour {

		public ControlUI controlUI;

		public void Personalizar(string direccionTexto, string direccionColor) {
			controlUI.Inicializar(new TraductorColor(direccionColor), new TraductorTexto(direccionTexto));
			controlUI.ActualizarUI();
		}

	}

}