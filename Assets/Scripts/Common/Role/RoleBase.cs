using UnityEngine;

namespace Common.Role
{
    public class RoleBase : MonoBehaviour
    {
        [SerializeField] private SPUM_Prefabs prefab;

        void SetSprites(SPUM_SpriteList data)
        {
            prefab._spriteOBj.LoadSprite(data);
        }
    }
}