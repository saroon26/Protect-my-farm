using UnityEngine;

public class Aurthur : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Beast")) {
            Destroy(collision.gameObject);
            // ����� �� ��� ������ ��� ��� ��� ����� 5 ���� ���� ������
        } }
    // Update is called once per frame
    void Update()
    {
        
    }
}
