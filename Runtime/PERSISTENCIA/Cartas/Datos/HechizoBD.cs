using System.Collections.Generic;
using Bounds.Persistencia.Carta;

namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class HechizoBD {

		public string tipo;
		public string jugador;
		public int cantidad;
		public string etiqueta;
		public DatoBloqueCondicion condicionCarta;
		public List<string> fuentes;
		public int costeLP;
		public bool esAleatorio;
		public string tipoObjetivo;
		public int cantidadObjetivos;
		public string habilidad;
		public int bono;
		public int costeDescartar;
		public int costeSacrificio;
		public int nPrimeras;
		public int parametroID;
		public int parametroN;
		public int parametroJ;
		public DatoBloqueCondicion bloqueCondicion;

		public HechizoBD Clonar() {
			return new HechizoBD {
				tipo = this.tipo,
				jugador = this.jugador,
				cantidad = this.cantidad,
				etiqueta = this.etiqueta,
				costeLP = this.costeLP,
				esAleatorio = this.esAleatorio,
				tipoObjetivo = this.tipoObjetivo,
				cantidadObjetivos = this.cantidadObjetivos,
				habilidad = this.habilidad,
				bono = this.bono,
				costeDescartar = this.costeDescartar,
				costeSacrificio = this.costeSacrificio,
				nPrimeras = this.nPrimeras,
				parametroID = this.parametroID,
				parametroN = this.parametroN,
				parametroJ = this.parametroJ,

				condicionCarta = this.condicionCarta,
				bloqueCondicion = this.bloqueCondicion,

				fuentes = this.fuentes != null ? new List<string>(this.fuentes) : null
			};
		}
	}
}