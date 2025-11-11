using AutoMapper;
using FlashEng.Bll.Dto;
using FlashEng.Domain.Models;

namespace FlashEng.Bll.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User mappings
            CreateMap<User, UserDto>();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();

            // UserSettings mappings
            CreateMap<UserSettings, UserSettingsDto>();
            CreateMap<UserSettingsDto, UserSettings>();

            // Flashcard mappings
            CreateMap<Flashcard, FlashcardDto>();
            CreateMap<CreateFlashcardDto, Flashcard>();
            CreateMap<UpdateFlashcardDto, Flashcard>();

            // Order mappings
            CreateMap<Order, OrderDto>();
            CreateMap<CreateOrderDto, Order>();

            // OrderItem mappings
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<CreateOrderItemDto, OrderItem>();

            // Product mappings
            CreateMap<Product, ProductDto>();
        }
    }
}