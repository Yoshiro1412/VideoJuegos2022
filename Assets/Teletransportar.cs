using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportar : MonoBehaviour
{

    public GameObject teleportPosition;
    public GameObject teletransportador;
    public float moveSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Resetear posiciones
            teleportPosition.transform.position = transform.position;
            teletransportador.transform.position = transform.position;
            // Activar visuales
            teletransportador.SetActive(true);
            teleportPosition.SetActive(true);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            // Mover punto de teletransporte
            Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), teleportPosition.transform.position.z).normalized;
            teleportPosition.transform.position += direction * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            // Desactivar visuales
            teletransportador.SetActive(false);
            teleportPosition.SetActive(false);
        }
    }
}
