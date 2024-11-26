using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public enum WeaponType
    {
        Spring = 1,
        Gas = 2,
        Electric = 3
    }

    [Flags]
    public enum WeaponFireType
    {
        Semi = 1,
        Auto = 2,
        Burst = 4,
        BoltAction = 8,
        PumpAction = 16,
    }

    public enum WeaponAge
    {
        Unspecified = 1,
        WW1 = 2,
        WW2 = 3,
        ColdWar = 4,
        Modern = 5
    }

    public enum WeaponGearboxType
    {
        Unspecified = 1,
        Special = 2,
        V2 = 3,
        V2Mod = 4,
        V3 = 5,
        V6 = 6
    }

    public enum Manufacturer
    {
        GunCompany1 = 1,
        GunCompany2 = 2,
        GunCompany3 = 3
    }

    [Flags]
    public enum ItemMaterial
    {
        Polymer = 1,
        Aluminium = 2,
        AluminiumZink = 4,
        Plastic = 8,
        Steel = 16,
        Wood = 32
    }

    public enum MagazineType
    {
        LowCap = 1,
        RealCap = 2,
        MidCap = 3,
        HighCap = 4
    }

    public abstract class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        public string ProductId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int WarrantyPeriodMonths { get; set; }

        public decimal Weight { get; set; }
    }

    public class Replica : Product
    {
        [Required]
        public WeaponType WeaponType { get; set; }

        [Required]
        public WeaponAge WeaponAge { get; set; } = WeaponAge.Unspecified;

        [Required]
        public WeaponFireType WeaponFireType { get; set; }

        [Required]
        public ItemMaterial ItemMaterial { get; set; }

        [Required]
        public MagazineType MagazineType { get; set; }

        public WeaponGearboxType WeaponGearboxType { get; set; }

        public int MagazineCapacity { get; set; }

        [Required]
        public bool HasBattery { get; set; } = false;

        [Required]
        public bool HasHopUp { get; set; } = false;

        [Required]
        public bool HasBlowBack { get; set; } = false;

        public decimal Lenght { get; set; }

        public decimal BarrelLenght { get; set; }

        public int FPS { get; set; }
    }

    //public class Part : Product
    //{

    //}

    //public class Accessory : Product
    //{

    //}

    //public class Equipment : Product
    //{

    //}
}
