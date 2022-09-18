using AutoMapper;
using BerthaLutzStore.Core.Entities;
using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Application.Models.DeleteProduct;
using BerthaLutzStore.Application.Models.DeleteOrder;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.SearchOrder;
//using BerthaLutzStore.Application.Models.SearchAllUsers;
//using BerthaLutzStore.Application.Models.SearchAllProducts;
//using BerthaLutzStore.Application.Models.SearchAllOrders;

namespace BerthaLutzStore.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NewUserRequest, User>()
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address));
            CreateMap<NewProductRequest, Product>()
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage));
            CreateMap<NewOrderRequest, Order>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems));

            CreateMap<UpdateUserRequest, User>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address));
            CreateMap<UpdateProductRequest, Product>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage));
            CreateMap<UpdateOrderRequest, Order>()
                .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder))
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems));

            CreateMap<DeleteUserRequest, User>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser));
            CreateMap<DeleteProductRequest, Product>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct));
            CreateMap<DeleteOrderRequest, Order>()
                .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder));

            CreateMap<SearchUserRequest, User>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser));
            CreateMap<SearchProductRequest, Product>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct));
            CreateMap<SearchOrderRequest, Order>()
                .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder));

            //CreateMap<SearchAllUsersRequest, User>()
            //    .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser));
            //CreateMap<SearchAllProductsRequest, Product>()
            //    .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct));
            //CreateMap<SearchAllOrdersRequest, Order>()
            //    .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder));
        }


    }
}
