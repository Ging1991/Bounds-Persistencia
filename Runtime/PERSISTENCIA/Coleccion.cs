using System.Collections.Generic;
using Bounds.Persistencia.Datos;
using Bounds.Persistencia.Lectores;
using Ging1991.Core;

namespace Bounds.Persistencia {

	public class Coleccion {

		public string codigo;
		public string titulo;
		public string nombre;
		public CartaColeccionBD emblema;
		public List<CartaColeccionBD> comunes;
		public List<CartaColeccionBD> infrecuentes;
		public List<CartaColeccionBD> raras;
		public List<CartaColeccionBD> miticas;
		public List<CartaColeccionBD> secretas;


		public Coleccion(string codigo, string direccion) {
			LectorColeccion lector = new LectorColeccion(direccion);
			ColeccionBD datos = lector.Leer();

			comunes = Convertir(datos.comunes);
			infrecuentes = Convertir(datos.infrecuentes);
			raras = Convertir(datos.raras);
			miticas = Convertir(datos.miticas);
			secretas = Convertir(datos.secretas);
			this.codigo = codigo;
			titulo = datos.titulo;
			nombre = datos.nombre;
			emblema = new CartaColeccionBD(datos.emblema);
		}


		public List<CartaColeccionBD> GetListaCompleta() {
			List<CartaColeccionBD> lista = new();
			lista.AddRange(comunes);
			lista.AddRange(infrecuentes);
			lista.AddRange(raras);
			lista.AddRange(miticas);
			lista.AddRange(secretas);
			return lista;
		}


		private List<CartaColeccionBD> Convertir(List<string> claves) {
			List<CartaColeccionBD> CartaColeccionBDs = new();
			foreach (var clave in claves) {
				CartaColeccionBDs.Add(new CartaColeccionBD(clave));
			}
			return CartaColeccionBDs;
		}


		public Sobre CrearSobre() {
			Sobre sobre = new();
			sobre.comunes.Add(Azar<CartaColeccionBD>.ValorAleatorio(comunes));
			sobre.comunes.Add(Azar<CartaColeccionBD>.ValorAleatorio(comunes));
			sobre.comunes.Add(Azar<CartaColeccionBD>.ValorAleatorio(comunes));
			sobre.infrecuentes.Add(Azar<CartaColeccionBD>.ValorAleatorio(infrecuentes));
			sobre.infrecuentes.Add(Azar<CartaColeccionBD>.ValorAleatorio(infrecuentes));
			sobre.rarezaSobre = Azar<string>.ValorAleatorio(new List<string>() { "MIT", "ORO", "ORO", "MIT", "ORO", "ORO", "MIT", "ORO", "ORO", "SEC" });
			if (sobre.rarezaSobre == "SEC" && secretas != null && secretas.Count > 0) {
				sobre.rara = Azar<CartaColeccionBD>.ValorAleatorio(secretas);
			}
			else if (sobre.rarezaSobre == "MIT") {
				sobre.rara = Azar<CartaColeccionBD>.ValorAleatorio(miticas);
			}
			else {
				sobre.rarezaSobre = "ORO";
				sobre.rara = Azar<CartaColeccionBD>.ValorAleatorio(raras);
			}
			return sobre;
		}


	}

}