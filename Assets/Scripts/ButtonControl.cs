using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    [SerializeField] private AudioClip core, anotherMedium;
    [SerializeField] private AudioSource speaker;
    [SerializeField] private GameObject lights, lightsBlue;
    private RaycastHit hit;
    private Ray ray;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit, 3))
        {
            GameObject objectHit = hit.transform.gameObject;

            if(Input.GetKeyDown(KeyCode.E))
            {
                if(objectHit.CompareTag("ButtonCore"))
                {
                    speaker.clip = core;
                    speaker.Play();
                }
                else if(objectHit.CompareTag("ButtonAnotherMedium"))
                {
                    speaker.clip = anotherMedium;
                    speaker.Play();
                }
                else if(objectHit.CompareTag("ButtonStop"))
                {
                    speaker.Stop();
                }
                else if(objectHit.CompareTag("ButtonLight"))
                {
                    lights.SetActive(!lights.activeSelf);
                }
                else if(objectHit.CompareTag("ButtonLightBlue"))
                {
                    lightsBlue.SetActive(!lightsBlue.activeSelf);
                }
            }
        }
    }
}
