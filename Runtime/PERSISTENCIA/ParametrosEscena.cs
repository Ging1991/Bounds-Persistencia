using System.Collections.Generic;
using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	[CreateAssetMenu(menuName = "Bounds/Parametros escena")]
	public class ParametrosEscena : ScriptableObject {

		private Dictionary<string, string> direcciones;

		[System.NonSerialized]
		public bool inicializado = false;

		public void Inicializar() {
			inicializado = false;
			direcciones = new();
		}

		public void SetDireccion(string clave, string valor) {
			direcciones[clave] = valor;
		}

		public string GetDireccion(string clave) {
			return direcciones[clave];
		}

	}

}