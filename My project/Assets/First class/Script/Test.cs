using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Monster
{
    public Monster()
    {
        Debug.Log("Monster�� �¾���ϴ�.");
    }
}

public class Test : MonoBehaviour
{
    public int value = 100;

    public int[] count;

    public int [] data = new int[3];

    void Start()
    {
        Debug.Log(value);
        Monster monster = new Monster();

        transform.position = new Vector3(0, transform.position.y, 1);

        foreach(var element in data)
        {
            Debug.Log(element);
        }
    }

    void Update()
    {
        // GetKetDown Ű�� ������ ��
        //
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("�����̽� ����!");
        }
        else if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
    }
}
