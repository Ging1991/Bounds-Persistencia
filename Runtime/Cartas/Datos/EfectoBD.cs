namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class EfectoBD : IClonableCustom<EfectoBD> {

		public string clave;
		public string parametroTipo;
		public string parametroPerfeccion;
		public string parametroClase;
		public string parametroZona;
		public int parametroN;
		public int parametroNMaximo;
		public int parametroNMinimo;
		public int parametroID;
		public int parametroATK;
		public int parametroDEF;
		public string parametroHabilidad;

		public EfectoBD Clonar() {
			return (EfectoBD)this.MemberwiseClone();
		}

	}

}