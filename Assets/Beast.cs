using UnityEngine;

public class Beast : MonoBehaviour
{
    public GameObject Arther;
    public float speed = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Arther = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Arther.transform);
        transform.Translate(transform.forward*speed *Time.deltaTime);
    }
}



// ÇÖÇİÉ ÓÑÚÉ ãÍÏÏÉ 
// ÈÑíİÇÈ 
// äÍÏÏ ÇáÇÊÌÇå ÚÔÇä ãÇ íÏæÑ 
// ÇÖÇİÉ ÍÑßÇÊ ãËá ÇáÖÑÈ 


