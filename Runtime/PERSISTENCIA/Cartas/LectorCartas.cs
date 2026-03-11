using Bounds.Modulos.Cartas.Persistencia.Datos;
using Ging1991.Core;
using Ging1991.Persistencia.Direcciones;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Modulos.Cartas.Persistencia {

	public class LectorCartas : ProveedorPerezoso<int, CartaBD> {

		private readonly Direccion carpeta;

		public LectorCartas(Direccion carpeta) {
			this.carpeta = carpeta;
		}

		public override CartaBD GenerarElemento(int cartaID) {
			LectorInterno lectorInterno = new(carpeta.Generar($"carta{cartaID}"));
			return lectorInterno.Leer();
		}

	}

	public class LectorInterno : LectorGenerico<CartaBD> {

		public LectorInterno(string direccion) : base(direccion, TipoLector.RECURSOS) { }

	}

}