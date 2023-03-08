using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoins : MonoBehaviour
{
    public int PuntosTotales{ get { return puntosTotales; }}
    private int puntosTotales;

    public void SumarPuntos(int puntosASumar)
    {
    puntosTotales += puntosASumar;
    Debug.Log(puntosTotales);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
