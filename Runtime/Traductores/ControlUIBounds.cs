using Bounds.Persistencia.proveedores;
using Ging1991.Interfaces.Personalizacion;
using Ging1991.Persistencia.Lectores;
using Ging1991.Persistencia.Proveedores;
using UnityEngine;

namespace Bounds.Persistencia {//

	public class ControlUIBounds : MonoBehaviour {

		public ControlUI controlUI;

		public void Personalizar(string direccionTexto, string direccionColor) {
			controlUI.Inicializar(
				new ProveedorColores(direccionColor, TipoLector.RECURSOS),
				new ProveedorTexto(direccionTexto, TipoLector.RECURSOS)
			);
			controlUI.ActualizarUI();
		}

	}

}