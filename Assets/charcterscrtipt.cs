using UnityEngine;

public class charcterscrtipt : MonoBehaviour
{

    public GameObject bulletclone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Instantiate(bulletclone, transform.position, transform.rotation);
        }
    }
 
}
