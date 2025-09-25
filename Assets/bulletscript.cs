using UnityEngine;

public class bulletscript : MonoBehaviour
{
    float bulletspeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletspeed * transform.forward * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("ouch!");
        healthbar possiblevictime = collision.transform.GetComponent<healthbar>();
        if (possiblevictime)
            possiblevictime.takedamage(25);

    }

}
