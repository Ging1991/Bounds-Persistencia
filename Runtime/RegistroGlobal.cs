using Ging1991.Core;

namespace Bounds.Persistencia {

	public class RegistroGlobal : Unico<RegistroGlobal> {

		public bool inicializado = false;
		public Billetera billetera;

		public void Inicializar(string direccionBilletera) {
			billetera = new Billetera(direccionBilletera);
			inicializado = true;
		}

	}

}