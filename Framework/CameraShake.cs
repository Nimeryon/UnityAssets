using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    Vector3 originalPos;

    private void Awake()
    {
        originalPos = transform.position;
    }

    public void Shake(float duration, float magnitude)
    {
        StartCoroutine(StartShake(duration, magnitude));
    }

    public IEnumerator StartShake(float duration, float magnitude)
    {
        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude * Time.deltaTime;
            float y = Random.Range(-1f, 1f) * magnitude * Time.deltaTime;

            transform.position = new Vector3(transform.position.x + x, transform.position.y + y, originalPos.z);
            elapsed += Time.deltaTime;

            yield return null;
        }
        transform.position = originalPos;
    }
}
