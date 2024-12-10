using AirsoftShop.Data;
using Microsoft.AspNetCore.Components;

namespace AirsoftShop.Components.Custom_Components.ItemEdit_Forms
{
    public partial class ReplicaEdit
    {
        [Parameter]
        public Replica Replica { get; set; } = new();

        private void ParseToBool(object args, Action<bool> setProperty)
        {
            if (string.IsNullOrEmpty(args?.ToString()))
            {
                return;
            }

            if (bool.TryParse(args.ToString(), out var result))
            {
                setProperty(result);
            }
        }

        private void ToggleMaterial(ItemMaterial material, bool isChecked)
        {
            if (isChecked)
            {
                Replica.ItemMaterial |= material;
            }
            else
            {

                Replica.ItemMaterial &= ~material;
            }
        }

        private void ToggleFireType(WeaponFireType fireType, bool isChecked)
        {
            if (isChecked)
            {
                Replica.WeaponFireType |= fireType;
            }
            else
            {

                Replica.WeaponFireType &= ~fireType;
            }
        }
    }
}