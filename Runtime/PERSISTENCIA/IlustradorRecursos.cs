using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class IlustradorRecursos : ISelector<string, Sprite> {

		private readonly DireccionRecursos direccionRecursos;
		private readonly Dictionary<string, Sprite> datos;

		public IlustradorRecursos(DireccionRecursos direccionRecursos) {
			this.direccionRecursos = direccionRecursos;
		}

		public Sprite GetElemento(string nombre) {
			if (!datos.ContainsKey(nombre)) {
				datos.Add(nombre, Resources.Load<Sprite>(direccionRecursos.Generar(nombre)));
			}
			return datos[nombre];
		}

	}

}