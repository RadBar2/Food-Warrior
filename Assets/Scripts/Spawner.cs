using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> food;
    public float throwForce = 500;

    [Header("Sounds")]
    public AudioClip foodSound;

    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(ThrowFood());
    }

    IEnumerator ThrowFood()
    {
        while (true)
        {
            var prefab = food[Random.Range(0, food.Count)];

            var right = Vector3.right * Random.Range(-0.5f, 0.5f);

            var foodItem = Instantiate(prefab, transform.position, Quaternion.identity);

            foodItem.GetComponent<Rigidbody>().AddForce((Vector3.up + right) * throwForce, ForceMode.Impulse);

            Destroy(foodItem, 5);

            audio.pitch = Random.Range(0.7f, 1.3f);
            audio.PlayOneShot(foodSound);

            yield return new WaitForSeconds(Random.Range(0, 3));
        }
        
    }
}
