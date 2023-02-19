using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCondition : MonoBehaviour
{
   public List<GameObject> Conditions = new List<GameObject>(); 
    private void Update()
    {
        int i = 0;
        foreach (GameObject item in Conditions)
        {
            if (item == null)
            {
              i++;
            }
        }
        if (i >= Conditions.Count)
        {
            Destroy(gameObject);
        }
    }
 public void DeleteItem(GameObject item)
    {
        Conditions.Remove(item);
    }

}
