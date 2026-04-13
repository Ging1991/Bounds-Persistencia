using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Lectores;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class TraductorColor : IProveedor<string, Color> {

		private readonly Dictionary<string, Color> datos;

		public TraductorColor(string direccion) {
			LectorMapa<string, ColorBD> lector = new(direccion, TipoLector.RECURSOS);
			Dictionary<string, ColorBD> datosBD = lector.LeerMapa();
			datos = new Dictionary<string, Color>();
			foreach (KeyValuePair<string, ColorBD> par in datosBD) {
				Color color = new(par.Value.r / 255f, par.Value.g / 255f, par.Value.b / 255f, par.Value.a / 255f);
				datos.Add(par.Key, color);
			}
		}

		public Color GetElemento(string clave) {
			if (datos.ContainsKey(clave)) {
				return datos[clave];
			}
			return Color.clear;
		}

	}

}