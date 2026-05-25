using System.Collections.Generic;
using Ging1991.Core;
using Ging1991.Dialogos.Persistencia;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Modulos.Visor.Persistencia {

	public class LectorHabilidades : ProveedorPerezoso<string, EfectoTraduccion> {

		private readonly List<EfectoTraduccion> lista;

		public LectorHabilidades(string direccion) {
			lista = new LectorInterno(direccion).GetLista();
		}


		public override EfectoTraduccion GenerarElemento(string clave) {
			EfectoTraduccion resultado = null;
			foreach (var dato in lista) {
				if (dato.clave == clave) {
					resultado = dato;
					break;
				}
			}
			return resultado;
		}


		private class LectorInterno : LectorLista<EfectoTraduccion> {

			public LectorInterno(string direccion) : base(direccion, TipoLector.RECURSOS) { }

		}


	}


}