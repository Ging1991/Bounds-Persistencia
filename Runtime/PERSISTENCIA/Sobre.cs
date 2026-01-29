using System.Collections.Generic;

namespace Bounds.Persistencia {

	public class Sobre {

		public List<CartaColeccionBD> comunes = new();
		public List<CartaColeccionBD> infrecuentes = new();
		public CartaColeccionBD rara;
		public string rarezaSobre;

	}

}