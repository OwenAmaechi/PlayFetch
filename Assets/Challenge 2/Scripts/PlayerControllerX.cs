using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
  public GameObject dogPrefab;
  private float pause = 0;


  // Update is called once per frame
  void Update()
  {
    // On spacebar press, send dog.
    if (Input.GetKeyDown(KeyCode.Space) && pause <= 0)
    {
      Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
      pause = 1;
    }
    if (pause >= 0)
    {
      pause -= Time.deltaTime;
    }
  }
}
