using AutoMapper;

namespace AirsoftShop.Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Replica, Product>();
            CreateMap<Part, Product>();
            CreateMap<Accessory, Product>();
            CreateMap<Equipment, Product>();

            CreateMap<Product, Replica>();
            CreateMap<Product, Part>();
            CreateMap<Product, Accessory>();
            CreateMap<Product, Equipment>();
        }
    }
}
