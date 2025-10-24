using UnityEngine;

public class SeguirCoiso : MonoBehaviour
{
    public Transform coiso;
    public Vector3 distancia;
    void Update()
    {
        transform.position=coiso.position+distancia;
    }
   
}
