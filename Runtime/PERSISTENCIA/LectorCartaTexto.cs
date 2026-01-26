using System.Collections.Generic;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Modulos.Persistencia {

	public class LectorCartaTexto : LectorMapa<int, string> {

		private readonly Dictionary<int, string> nombres;

		public LectorCartaTexto(string direccion) : base(direccion, TipoLector.RECURSOS) {
			nombres = LeerMapa();
		}

		public string GetNombre(int cartaID) {
			return nombres[cartaID];
		}

	}

}