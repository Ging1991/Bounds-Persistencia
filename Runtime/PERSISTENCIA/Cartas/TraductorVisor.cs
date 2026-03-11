using System.Collections.Generic;
using Ging1991.Persistencia.Lectores;
using UnityEngine;

namespace Bounds.Modulos.Visor.Persistencia {

	public class TraductorVisor : MonoBehaviour {

		public string direccion;
		public TipoLector tipoLector = TipoLector.RECURSOS;
		private Dictionary<string, string> datos;

		public void Inicializar() {
			LectorMapa<string, string> lector = new(direccion, tipoLector);
			datos = lector.LeerMapa();
		}

		public string GetTexto(string clave) {
			if (datos.ContainsKey(clave)) {
				return datos[clave];
			}
			Debug.LogWarning($"No se encontro la clave: {clave}");
			return clave;
		}

	}

}