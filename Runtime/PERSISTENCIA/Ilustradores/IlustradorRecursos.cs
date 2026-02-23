using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class IlustradorRecursos : Ilustrador {

		public IlustradorRecursos(DireccionRecursos direccionRecursos) : base(direccionRecursos) { }

		protected override Sprite LeerImagen(string direccion) {
			return Resources.Load<Sprite>(direccion);
		}

	}

}