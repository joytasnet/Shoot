using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject prefab;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Create());
        
    }
    IEnumerator Create() {
        float delta = 1.5f;
        while (true) {
            GameObject obj = Instantiate(
                prefab,
                new Vector3(
                    Random.Range(-10f, 10f),
                    Random.Range(8f, 12f),
                    Random.Range(-2f, 3f)
                    ),
                Quaternion.identity
            );
            obj.GetComponent<CubeController>().SetGameManager(gm);
            yield return new WaitForSeconds(delta);

            if(delta > 0.5f) {
                delta -= 0.05f;
            }

        }
    }
}
