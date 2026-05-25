namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class VacioBD {

		public string tipo;
		public string parametro;
		public string habilidad;
		public int bono;

		public VacioBD Clonar() {
			return (VacioBD)this.MemberwiseClone();
		}

	}
}