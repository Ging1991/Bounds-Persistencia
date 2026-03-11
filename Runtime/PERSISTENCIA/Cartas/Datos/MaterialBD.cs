namespace Bounds.Modulos.Cartas.Persistencia.Datos {

	[System.Serializable]
	public class MaterialBD : IClonableCustom<MaterialBD> {

		public string tipo;
		public string parametroClase;
		public string parametroTipo;
		public int parametroID;
		public int parametroATK;
		public int parametroDEF;

		public MaterialBD Clonar() {
			return (MaterialBD)this.MemberwiseClone();
		}
	}

}