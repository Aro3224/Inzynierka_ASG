using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Data
{
    public enum ProductType
    {
        [Display(Name = "Replika")]
        Replica = 1,

        [Display(Name = "Część")]
        Part = 2,

        [Display(Name = "Akcesoria")]
        Accessory = 3,

        [Display(Name = "Ekwipunek")]
        Equipment = 4
    }

    public enum WeaponType
    {
        [Display(Name = "Sprężynowa")]
        Spring = 1,

        [Display(Name = "Gazowa")]
        Gas = 2,

        [Display(Name = "Elektryczna")]
        Electric = 3
    }

    public enum WeaponCategory
    {
        [Display(Name = "Pistolet")]
        Pistol = 1,

        [Display(Name = "Pistolet Maszynowy")]
        MachinePistol = 2,

        [Display(Name = "Strzelba")]
        Shotgun = 3,

        [Display(Name = "Karabin Szturmowy/Karabinek")]
        AssaultRifle = 4,

        [Display(Name = "Karabin")]
        Carbine = 5,

        [Display(Name = "Karabin Snajperski")]
        SniperRifle = 6,

        [Display(Name = "Karabin Maszynowy")]
        MachineGun = 7,

        [Display(Name = "Inne")]
        SpecialWeapon = 8,
    }

    [Flags]
    public enum WeaponFireType
    {
        [Display(Name = "Pojedynczy")]
        Semi = 1,

        [Display(Name = "Ciągły")]
        Auto = 2,

        [Display(Name = "Seria")]
        Burst = 4,

        [Display(Name = "Czterotaktowy")]
        BoltAction = 8,

        [Display(Name = "Pompa")]
        PumpAction = 16,
    }

    public enum WeaponAge
    {
        [Display(Name = "Inne")]
        Unspecified = 1,

        [Display(Name = "1 wojna światowa")]
        WW1 = 2,

        [Display(Name = "2 wojna światowa")]
        WW2 = 3,

        [Display(Name = "Zimna wojna")]
        ColdWar = 4,

        [Display(Name = "Współczesność")]
        Modern = 5
    }

    public enum GearboxType
    {
        [Display(Name = "Brak")]
        None = 0,

        [Display(Name = "Inny")]
        Unspecified = 1,

        [Display(Name = "Specjalny")]
        Special = 2,
      
        [Display(Name = "V2 Ulepszony")]
        V2Mod = 4,

        V2 = 3,
        V3 = 5,
        V6 = 6
    }

    public enum Manufacturer
    {
        [Display(Name = "Gun Company 1")]
        GunCompany1 = 1,

        [Display(Name = "Gun Company 2")]
        GunCompany2 = 2,

        [Display(Name = "Gun Company 3")]
        GunCompany3 = 3
    }

    [Flags]
    public enum ItemMaterial
    {
        [Display(Name = "Polimer")]
        Polymer = 1,

        [Display(Name = "Aluminium")]
        Aluminium = 2,

        [Display(Name = "Cynk")]
        AluminiumZink = 4,

        [Display(Name = "Tworzywo sztuczne")]
        Plastic = 8,

        [Display(Name = "Metal")]
        Steel = 16,

        [Display(Name = "Drewno")]
        Wood = 32
    }

    public enum MagazineType
    {
        [Display(Name = "Low-cap")]
        LowCap = 1,

        [Display(Name = "Real-cap")]
        RealCap = 2,

        [Display(Name = "Mid-cap")]
        MidCap = 3,

        [Display(Name = "High-cap")]
        HighCap = 4
    }

    public enum PartType
    {
        None = 0,

        [Display(Name = "Wewnętrzna")]
        Internal = 1,

        [Display(Name = "Zewnętrzna")]
        External = 2,
    }

    public enum ExternalPartType
    {
        None = 0,

        [Display(Name = "Magazynek")]
        Magazine = 1,

        [Display(Name = "Kolimator/Luneta")]
        Scope = 2,

        [Display(Name = "Celownik mechaniczny")]
        Ironsight = 3,

        [Display(Name = "Uchwyt")]
        Grip = 4,

        [Display(Name = "Montaż")]
        Mount = 5,

        [Display(Name = "Kolba/Dodatek")]
        Stock = 6,

        [Display(Name = "Latarka taktyczna")]
        Flashlight = 7,

        [Display(Name = "Dodatek do lufy")]
        BarrelMod = 8,

        [Display(Name = "Dwójnóg")]
        Bipod = 9,

        [Display(Name = "Część korpusu")]
        BodyPart = 10,

        [Display(Name = "Inne")]
        Unspecified = 11
    }

    public enum InternalPartType
    {
        None = 0,

        [Display(Name = "Gearbox")]
        Gearbox = 1,

        [Display(Name = "Szkielet gearboxa")]
        GearboxSkeleton = 2,

        [Display(Name = "Tłok")]
        Piston = 3,

        [Display(Name = "Głowica tłoku")]
        PistonHead = 4,

        [Display(Name = "Cylinder")]
        Cylinder = 5,

        [Display(Name = "Głowica cylindra")]
        CylinderHead = 6,

        [Display(Name = "Dysza")]
        Nozzle = 7,

        [Display(Name = "Koło zębate")]
        GearWheel = 8,

        [Display(Name = "Łożysko")]
        Bearing = 9,

        [Display(Name = "Lufa wewnętrzna")]
        InnerBarrel = 10,

        [Display(Name = "Lufa precyzyjna")]
        PrecisionBarrel = 11,

        [Display(Name = "Komora Hop-up")]
        HopUpChamber = 12,

        [Display(Name = "Gumka Hop-up")]
        HopUpRubber = 13,

        [Display(Name = "Spust")]
        Trigger = 14,

        [Display(Name = "Elektronika")]
        Electronics = 15,

        [Display(Name = "Silnik")]
        Engine = 16,

        [Display(Name = "Listwa dosyłacza")]
        FeederRail = 17,

        [Display(Name = "Płytka selektora")]
        SelectorPlate = 18,

        [Display(Name = "Prowadnica sprężyn")]
        SpringGuide = 19,

        [Display(Name = "Sprężyna")]
        Spring = 20,

        [Display(Name = "Część do repliki gazowej")]
        GbbPart = 21,

        [Display(Name = "Część do repliki snajperskiej")]
        SniperPart = 22,

        [Display(Name = "Inne")]
        Unspecified = 23
    }

    public enum BbType
    {
        [Display(Name = "Standardowe")]
        Normal = 1,

        [Display(Name = "Biodegradowalne")]
        Bio = 2,

        [Display(Name = "Podświetlane")]
        Tracer = 3,

        [Display(Name = "Inne")]
        Unspecified = 4
    }

    public enum GasType
    {
        [Display(Name = "Green Gas")]
        GreenGas = 1,

        [Display(Name = "CO2")]
        Carbon = 2,
    }

    public enum BatteryType
    {
        [Display(Name = "Li-Po")]
        LiPo = 1,

        [Display(Name = "Li-Ion")]
        LiIon = 2,

        [Display(Name = "Li-Fe")]
        LiFe = 3,

        [Display(Name = "NiMH/NiCd")]
        NiMH = 4,

        [Display(Name = "Inne")]
        Unspecified = 5
    }

    public enum BatteryPlug
    {
        [Display(Name = "T-connector")]
        TConnector = 1,

        [Display(Name = "Mała Tamiya")]
        TamiyaSmall = 2,

        [Display(Name = "Duża Tamiya")]
        TamiyaLarge = 3,

        [Display(Name = "Inne")]
        Unspecified = 4
    }

    public enum BatteryVoltage
    {
        [Display(Name = "7,2V")]
        Voltage_7_2 = 1,

        [Display(Name = "7,4V")]
        Voltage_7_4 = 2,

        [Display(Name = "8,4V")]
        Voltage_8_4 = 3,

        [Display(Name = "9,6V")]
        Voltage_9_6 = 4,

        [Display(Name = "10,8V")]
        Voltage_10_8 = 5,

        [Display(Name = "11,1V")]
        Voltage_11_1 = 6,
    }

    public enum AccessoryType
    {
        None = 0,

        [Display(Name = "Kulki/Amunicja")]
        Bbs = 1,

        [Display(Name = "Gaz")]
        Gas = 2,

        [Display(Name = "Ładowarka")]
        Charger = 3,

        [Display(Name = "Bateria")]
        Battery = 4,

        [Display(Name = "Farba")]
        Paint = 5,

        [Display(Name = "Olej")]
        Oil = 6,

        [Display(Name = "Narzędzie")]
        Tool = 7,

        [Display(Name = "Ekwipunek strzelniczy")]
        Equipment = 8,

        [Display(Name = "Inne")]
        Unspecified = 9,
    }

    public abstract class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Count { get; set; } = 1;

        public string Description { get; set; }

        [Required]
        public string ProductId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public int WarrantyPeriodMonths { get; set; }

        public decimal Weight { get; set; }

        public abstract ProductType ProductType { get; }
    }

    public class Replica : Product
    {
        public override ProductType ProductType => ProductType.Replica;

        [Required]
        public WeaponType WeaponType { get; set; }

        [Required]
        public WeaponCategory WeaponCategory { get; set; }

        [Required]
        public WeaponAge WeaponAge { get; set; } = WeaponAge.Unspecified;

        [Required]
        public WeaponFireType WeaponFireType { get; set; }

        [Required]
        public ItemMaterial ItemMaterial { get; set; }

        [Required]
        public MagazineType MagazineType { get; set; }

        public GearboxType WeaponGearboxType { get; set; }

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

    public class Part : Product
    {
        public override ProductType ProductType => ProductType.Part;

        [Required]
        public PartType PartType { get; set; } = PartType.None;

        public InternalPartType InternalPartType { get; set; }

        public ExternalPartType ExternalPartType { get; set; }

        public ItemMaterial ItemMaterial { get; set; }

        public MagazineType MagazineType { get; set; }

        public int MagazineCapacity { get; set; }

        public GearboxType GearboxType { get; set; }

        public decimal ItemLenght { get; set; }

        public decimal BearingDiameter { get; set; }
    }

    public class Accessory : Product
    {
        public override ProductType ProductType => ProductType.Accessory;

        public AccessoryType AccessoryType { get; set; }

        public decimal BbWeight { get; set; }

        public BbType BbType { get; set; }

        public int Bbsize { get; set; } = 6;

        public GasType GasType { get; set; }

        public BatteryType BatteryType { get; set; }

        public BatteryPlug BatteryPlug { get; set; }

        public BatteryVoltage BatteryVoltage { get; set; }
    }

    public class Equipment : Product
    {
        public override ProductType ProductType => ProductType.Equipment;
    }
}
