using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
  // Detecta triggers con otros objetos
  void OnTriggerEnter(Collider other)
  {
    // Obtiene la etiqueta del objeto que activó el trigger
    string otherObjectTag = other.gameObject.tag;
    
    // Muestra un mensaje en la consola
    Debug.Log("Trigger activado por: " + otherObjectTag);
}
}
