using Bounds.Persistencia.Datos;
using Ging1991.Persistencia.Lectores;

namespace Bounds.Persistencia.Lectores {

	public class LectorConfiguracion : LectorGenerico<ConfiguracionBD> {

		public LectorConfiguracion(string direccion) : base(direccion, TipoLector.DINAMICO) {
			if (!ExistenDatos()) {
				ConfiguracionBD dato = new() {
					capituloHistoria = 1,
					capituloLeccion = 1,
					inicioCarta = 7,
					inicioPersonaje = 1,
					idioma = "ESPAÑOL"
				};
				Guardar(dato);
			}
		}

	}

}