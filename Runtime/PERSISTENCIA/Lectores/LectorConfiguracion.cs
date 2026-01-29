using Bounds.Persistencia.Datos;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Persistencia.Lectores {

	public class LectorConfiguracion : LectorGenerico<ConfiguracionBD> {

		private readonly int ORO_INICIAL = 20000;

		public LectorConfiguracion(string direccion) : base(direccion, TipoLector.DINAMICO) {
			if (!ExistenDatos()) {
				ConfiguracionBD dato = new();
				dato.capituloHistoria = 1;
				dato.capituloLeccion = 1;
				dato.inicioCarta = 7;
				dato.inicioPersonaje = 1;
				dato.oro = ORO_INICIAL;
				dato.idioma = "ESPAÑOL";
				Guardar(dato);
			}
		}

	}

}