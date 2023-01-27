using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is an example for teaching basic translation in unity
/// </summary>
public class BasicObjectMotionDemo : MonoBehaviour
{
    [Header("Translation Settings")]
    [SerializeField] private bool translate;
    [SerializeField] private float translationSpeed;

    [Header("Rotation Settings")]
    [SerializeField] private bool rotate;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private Vector3 rotationVector;

    void Update()
    {
        if (translate)
        {
            float sideMotion = Input.GetAxis("Horizontal") * translationSpeed;
            float forwardMotion = Input.GetAxis("Vertical") * translationSpeed;
            // Transform is a monobehavior field that holds this objects transformation data
            transform.Translate(new Vector3(sideMotion, 0f, forwardMotion) * translationSpeed * Time.deltaTime, Space.World);
            
        }

        if(rotate)
        {
            transform.Rotate(rotationVector * rotationSpeed * Time.deltaTime, Space.Self);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            // gameobject is a monobehavior field that refers to the object this monobehavior is attached to
            Destroy(gameObject);
        }
    }
}
