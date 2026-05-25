using System.Collections.Generic;

namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class CartaBD {

		public int cartaID;
		public int nivel;
		public int defensa;
		public string nombre;
		public string clase;
		public string ambientacion;
		public string efecto;
		public List<string> informacion;
		public List<string> etiquetas;
		public CriaturaBD datoCriatura;
		public HechizoBD datoHechizo;
		public TrampaBD datoTrampa;
		public VacioBD datoVacio;
		public List<EfectoBD> efectos;
		public List<MaterialBD> materiales;

		public CartaBD Clonar() {
			return new CartaBD {
				cartaID = this.cartaID,
				nivel = this.nivel,
				defensa = this.defensa,
				nombre = this.nombre,
				clase = this.clase,
				ambientacion = this.ambientacion,
				efecto = this.efecto,
				informacion = this.informacion != null ? new List<string>(this.informacion) : null,
				etiquetas = this.etiquetas != null ? new List<string>(this.etiquetas) : null,

				// Copia profunda de objetos anidados (asumiendo que tienen su propio Clonar)
				datoCriatura = this.datoCriatura?.Clonar(),
				datoHechizo = this.datoHechizo?.Clonar(),
				datoTrampa = this.datoTrampa?.Clonar(),
				datoVacio = this.datoVacio?.Clonar(),

				// Copia profunda de listas de objetos complejos
				efectos = ClonarLista(this.efectos),
				materiales = ClonarLista(this.materiales)
			};
		}

		private List<T> ClonarLista<T>(List<T> listaOriginal) where T : IClonableCustom<T> {
			if (listaOriginal == null) return null;

			List<T> nuevaLista = new List<T>();
			foreach (var item in listaOriginal) {
				nuevaLista.Add(item.Clonar());
			}
			return nuevaLista;
		}
	}

}