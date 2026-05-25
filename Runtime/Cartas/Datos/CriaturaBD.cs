using System.Collections.Generic;

namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class CriaturaBD {

		public int ataque;
		public int defensa;
		public string perfeccion;
		public List<string> tipos;
		public List<EfectoBD> efectos;

		public CriaturaBD Clonar() {
			return new CriaturaBD {
				ataque = this.ataque,
				defensa = this.defensa,
				perfeccion = this.perfeccion,
				tipos = this.tipos != null ? new List<string>(this.tipos) : null,
				efectos = ClonarListaEfectos(this.efectos)
			};
		}

		private List<EfectoBD> ClonarListaEfectos(List<EfectoBD> listaOriginal) {
			if (listaOriginal == null) return null;

			List<EfectoBD> nuevaLista = new List<EfectoBD>();
			foreach (var efecto in listaOriginal) {
				nuevaLista.Add(efecto.Clonar());
			}
			return nuevaLista;
		}
	}

}