using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{//�̵��� ����� ������ٵ� ������Ʈ
    public Rigidbody playerRigidbody;
    //�̵��ӷ�
    public float speed = 3f;
    //�� �ڽ��� ���� ���� 
    public GameObject my;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
    }


    void Die()
    {
        //������� �������� �Է°��� �����ؼ� ����
        float xinput = Input.GetAxis("Horizontal");
        //Ű���� : 'A',<- : ���ǹ���
        //Ű���� : 'D',-> : ���ǹ���
        float zinput = Input.GetAxis("Vertical");
        //Ű���� : 'W', ^: ���ǹ��� : + 1.0f
        //Ű���� : 'S',��: ���ǹ��� : - 1.0f
    void Directinput();

    my.SetActive(false);

        private void start()
        {
            //���ӿ�����Ʈ���� Rigidbody ������Ʈ�� ã��
            //playerRigidbody�� �Ҵ�
             playerRigidbody = GetComponent<Rigidbody>();

            

            }
       
    }
}
