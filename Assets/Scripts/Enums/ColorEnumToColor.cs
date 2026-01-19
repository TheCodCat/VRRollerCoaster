using UnityEngine;

namespace Assets.Scripts.Enums
{
    public static class ColorEnumToColor
    {
        public static Color ToColor(this CellColorEnum colorEnum)
        {
            return colorEnum switch
            {
                CellColorEnum.empty => Color.white,
                CellColorEnum.forvard => Color.green,
                _ => Color.black
            };
        }
    }
}
