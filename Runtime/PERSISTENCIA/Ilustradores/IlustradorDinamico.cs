using System.IO;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class IlustradorDinamico : Ilustrador {

		public IlustradorDinamico(DireccionDinamica direccionDinamica) : base(direccionDinamica) { }

		protected override Sprite LeerImagen(string direccion) {
			if (File.Exists(direccion)) {
				byte[] bytes = File.ReadAllBytes(direccion);
				Texture2D textura = new Texture2D(2, 2);
				textura.LoadImage(bytes);
				if (textura != null) {
					return Sprite.Create(textura, new Rect(0, 0, textura.width, textura.height), new Vector2(0.5f, 0.5f));
				}
				return null;
			}
			return null;
		}

	}

}