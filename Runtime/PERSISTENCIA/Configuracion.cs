using Bounds.Persistencia.Datos;
using Bounds.Persistencia.Lectores;

namespace Bounds.Persistencia {

	public class Configuracion {

		private readonly LectorConfiguracion lector;

		public Configuracion(string direccion) {
			lector = new LectorConfiguracion(direccion);
		}


		public string GetIdioma() {
			return lector.Leer().idioma;
		}


		public void SetIdioma(string idioma) {
			lector.Leer().idioma = idioma;
			lector.Guardar();
		}


		public string GetNombre() {
			return lector.Leer().nombre;
		}


		public void SetNombre(string nombre) {
			lector.Leer().nombre = nombre;
			lector.Guardar();
		}


		public void GuardarCapituloLeccion(int capitulo) {
			if (capitulo > 9 || capitulo < 1) {
				capitulo = 1;
			}
			ConfiguracionBD datos = lector.Leer();
			datos.capituloLeccion = capitulo;
			lector.Guardar();
		}


		public void GuardarCapituloHistoria(int capitulo) {
			if (capitulo > 6 || capitulo < 1) {
				capitulo = 1;
			}
			ConfiguracionBD datos = lector.Leer();
			datos.capituloHistoria = capitulo;
			lector.Guardar();
		}


		public void GuardarInicioCarta(int cartaID) {
			if (cartaID > 497 || cartaID < 1)
				cartaID = 1;
			ConfiguracionBD datos = lector.Leer();
			datos.inicioCarta = cartaID;
			lector.Guardar();
		}


		public void GuardarInicioPersonaje(int personaje) {
			if (personaje > 500 || personaje < 1)
				personaje = 1;
			ConfiguracionBD datos = lector.Leer();
			datos.inicioPersonaje = personaje;
			lector.Guardar();
		}


		public int LeerCapituloLeccion() {
			return lector.Leer().capituloLeccion;
		}


		public int LeerCapituloHistoria() {
			return lector.Leer().capituloHistoria;
		}


		public int LeerInicioCarta() {
			return lector.Leer().inicioCarta;
		}


		public int LeerInicioPersonaje() {
			return lector.Leer().inicioPersonaje;
		}


	}

}