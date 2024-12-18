using System.ComponentModel.DataAnnotations;

namespace AirsoftShop.Enums
{
    public enum SortingOption
    {
        [Display(Name = "Domyślne")]
        None,

        [Display(Name = "Cena rosnąco")]
        PriceAsc,

        [Display(Name = "Cena malejąco")]
        PriceDesc,

        [Display(Name = "Nazwa A-Z")]
        NameAsc,

        [Display(Name = "Nazwa Z-A")]
        NameDesc
    }
}
