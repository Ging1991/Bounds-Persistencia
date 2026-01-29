namespace Bounds.Persistencia {

	public class CartaColeccionBD {

		public int cartaID;
		public string imagen;

		public CartaColeccionBD(string codigo) {
			var partes = codigo.Split('_');
			cartaID = int.Parse(partes[0]);
			imagen = partes[1];
		}

	}

}