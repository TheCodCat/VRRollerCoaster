using Assets.Scripts.Enums;
using UnityEngine;

public class CellItem : MonoBehaviour
{
    [SerializeField] private CellColorEnum cellState;
    [SerializeField] private MeshRenderer m_Renderer;

    private void OnEnable()
    {
        m_Renderer.material.color = cellState.ToColor();
    }

    public void ChangeState()
    {
        var newState = cellState switch 
        {
            CellColorEnum.empty => CellColorEnum.forvard,
            CellColorEnum.forvard => CellColorEnum.empty,
            _ => CellColorEnum.empty
        };

        cellState = newState;
        m_Renderer.material.color = cellState.ToColor();
    }
}
