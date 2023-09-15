using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericContainerExample : MonoBehaviour
{
    private GenericContainer<int> intContainer;
    private GenericContainer<string> stringContainer;
    // Start is called before the first frame update
    void Start()
    {
        intContainer = new GenericContainer<int>(10);
        stringContainer = new GenericContainer<string>(15);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            intContainer.Add(Random.Range(0, 100));
            DisplayContainerItems(intContainer);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            string randomString = " item " + Random.Range(0, 100);
            stringContainer.Add(randomString);
            DisplayContainerItems(stringContainer);
        }
    }



    private void DisplayContainerItems<T>(GenericContainer<T> container)
    {//������ �����̳ʸ� Debug.Log���� �� �� �ְ� ���� �Լ� 
        T[] items = container.GetItems();
        string temp = "";
        for (int i = 0; i < items.Length; i++) //�����̳ʸ� ��ȯ�ؼ� �迭���� ���ڿ��� ��ȯ
        {
            if (items[i] != null)
            {
                temp += items[i].ToString() + " - ";    //���ʸ� ���°��� String ���� ��ȯ
            }
            else
            {
                temp += "Empty - ";                     //��������� Empty ���ڿ�
            }
        }
        Debug.Log(temp);
    }
}
