using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogCooldownDuration = 1.0f;

    private bool dogLoaded = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogLoaded)
        {
            dogLoaded = false;
            Invoke("ReloadDog", dogCooldownDuration);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }

    void ReloadDog()
    {
        dogLoaded = true;
    }
}
