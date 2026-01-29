using System.Collections.Generic;

namespace Bounds.Modulos.Persistencia {

	[System.Serializable]
	public class ColeccionBD {

		public string codigo;
		public string titulo;
		public string nombre;
		public string emblema;
		public List<string> comunes;
		public List<string> infrecuentes;
		public List<string> raras;
		public List<string> miticas;
		public List<string> secretas;

	}

}