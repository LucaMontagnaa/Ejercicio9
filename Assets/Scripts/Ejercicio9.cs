using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string persona1;
    public string persona2;
    public string persona3;
    public int Aporte1;
    public int Aporte2;
    public int Aporte3;
    private int total;

    void Start()
    {
        total = (Aporte1 + Aporte2 + Aporte3);
        Debug.Log("Nombre: " + persona1 + " - Capital aportado: $" + Aporte1 + " - Porcentaje del capital: %" + (Aporte1 * 100) / total + " - Monto total aportado: $" + total);
        Debug.Log("Nombre: " + persona2 + " - Capital aportado: $" + Aporte2 + " - Porcentaje del capital: %" + (Aporte2 * 100) / total + " - Monto total aportado: $" + total);
        Debug.Log("Nombre: " + persona3 + " - Capital aportado: $" + Aporte3 + " - Porcentaje del capital: %" + (Aporte3 * 100) / total + " - Monto total aportado: $" + total);

    }

    
}
