using System.Collections.Generic;
using UnityEngine;

namespace Bounds.Persistencia.Parametros {

	[CreateAssetMenu(menuName = "Bounds/Parametros escena")]
	public class ParametrosEscena : ScriptableObject {

		public Dictionary<string, string> direcciones;
		public string escenaPadre;

		[System.NonSerialized]
		public bool inicializado = false;

		public void Inicializar() {
			inicializado = false;
			direcciones = new();
		}

	}

}