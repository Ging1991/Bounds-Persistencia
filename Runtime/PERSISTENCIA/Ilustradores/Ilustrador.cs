using System.Collections.Generic;
using Ging1991.Core.Interfaces;
using Ging1991.Persistencia.Direcciones;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public abstract class Ilustrador : ISelector<string, Sprite> {

		private readonly Direccion direccionCarpeta;
		private readonly Dictionary<string, Sprite> datos;

		public Ilustrador(Direccion direccionCarpeta) {
			this.direccionCarpeta = direccionCarpeta;
			datos = new();
		}

		public Sprite GetElemento(string nombre) {
			if (!datos.ContainsKey(nombre)) {
				datos.Add(nombre, LeerImagen(direccionCarpeta.Generar(nombre)));
			}
			return datos[nombre];
		}

		protected abstract Sprite LeerImagen(string direccion);

	}

}