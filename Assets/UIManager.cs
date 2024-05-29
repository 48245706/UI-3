using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text txtFruta;
    public string nombreFruta;
    // lograr que al presionar el botón se muestre un nombre al azar
    // de un array de al menos 4 elementos

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateFruta()
    {
        txtFruta.text = nombreFruta;
    } 
}
