using UnityEngine;

[CreateAssetMenu]

public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num = 0;

public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.data, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        for(int i = 0; i < obj.vector3List.Count; i++)
        {
            Instantiate(prefab, obj.vector3List[i].data, Quaternion.identity);
        }
        
    }

    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3List[num].data, Quaternion.identity);
        num++;
        if(num == obj.vector3List.Count)
        {
            num = 0;
        }

    }


    public void CreateInstanceFromListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3List.Count);
        Instantiate(prefab, obj.vector3List[num].data, Quaternion.identity);

    }
}
