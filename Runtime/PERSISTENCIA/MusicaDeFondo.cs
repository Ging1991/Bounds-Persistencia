using UnityEngine;

namespace Bounds.Modulos.Persistencia {

	public class MusicaDeFondo : MonoBehaviour {
		public AudioSource componente;

		public void Inicializar(string direccion) {
			AudioClip clip = Resources.Load<AudioClip>(direccion);

			if (clip == null) {
				Debug.LogError("No se pudo cargar el audio en: " + direccion);
				return;
			}

			componente.clip = clip;
			componente.loop = true;
			componente.Play();
		}

	}

}