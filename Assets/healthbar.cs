using UnityEngine;

public class healthbar : MonoBehaviour
{
    int Mhp = 100;
    int Chp = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void takedamage(int howmuchdamage)
    {
        Chp -= howmuchdamage;
        if (Chp<=0)
        {
            Destroy(gameObject);
        }
    }
}
