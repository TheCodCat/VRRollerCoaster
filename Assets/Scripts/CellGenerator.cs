using System.Collections;
using UnityEngine;

public class CellGenerator : MonoBehaviour
{
    [SerializeField] private int countX;
    [SerializeField] private int countY;
    [SerializeField] private CellItem cell;
    [SerializeField] private float addPosition;
    [SerializeField] private Transform startPostion;

    private IEnumerator Start()
    {
        for (int i = 0; i < countX; i++)//x
        {
            float posX = startPostion.position.x + i * addPosition;
            for (int j = 0; j < countY; j++)//y
            {
                float posY = startPostion.position.z + j * addPosition;

                Debug.Log($"{i} - {j}");
                var item = Instantiate(cell);

                item.transform.SetPositionAndRotation(new Vector3(posX, startPostion.position.y, posY), Quaternion.identity);
                yield return null;
            }
        }
    }
}
