using AutoMapper;
using BerthaLutzStore.Core.Entities;
using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.NewProduct;
using BerthaLutzStore.Application.Models.NewOrder;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Application.Models.SearchProduct;
using BerthaLutzStore.Application.Models.SearchOrder;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.UpdateProduct;
using BerthaLutzStore.Application.Models.UpdateOrder;
using BerthaLutzStore.Application.Models.SearchAllUsers;
using BerthaLutzStore.Application.Models.SearchAllProducts;
using BerthaLutzStore.Application.Models.SearchAllOrders;
using System;

namespace BerthaLutzStore.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            #region New
            CreateMap<NewUserRequest, User>()
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => DateTime.Now));

            CreateMap<NewProductRequest, Product>()
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => DateTime.Now));

            CreateMap<NewOrderRequest, Order>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.ShippingDate, fonte => fonte.MapFrom(src => DateTime.Now.AddDays(15)))
                .ForMember(dest => dest.OrderedAt, fonte => fonte.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems));

            CreateMap<AddItemOrderRequest, ItemOrder>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.Quantity, fonte => fonte.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitPrice, fonte => fonte.MapFrom(src => src.UnitPrice));
            #endregion

            #region Update
            CreateMap<UpdateUserRequest, User>()
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address));

            CreateMap<UpdateProductRequest, Product>()
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage));

            CreateMap<UpdateOrderRequest, Order>()
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems));

            CreateMap<UpdateOrderedItemsRequest, ItemOrder>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.Quantity, fonte => fonte.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitPrice, fonte => fonte.MapFrom(src => src.UnitPrice));
            #endregion

            #region SearchById
            CreateMap<User, SearchUserResponse>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => src.RegisteredAt));

            CreateMap<Product, SearchProductResponse>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => src.RegisteredAt));

            CreateMap<Order, SearchOrderResponse>()
                .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder))
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems))
                .ForMember(dest => dest.ShippingDate, fonte => fonte.MapFrom(src => src.ShippingDate))
                .ForMember(dest => dest.Total, fonte => fonte.MapFrom(src => src.Total))
                .ForMember(dest => dest.OrderedAt, fonte => fonte.MapFrom(src => src.OrderedAt));

            CreateMap<ItemOrder, SearchOrderedItemsResponse>()
                .ForMember(dest => dest.IdItemOrder, fonte => fonte.MapFrom(src => src.IdItemOrder))
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.Quantity, fonte => fonte.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitPrice, fonte => fonte.MapFrom(src => src.UnitPrice));
            #endregion
            
            #region SearchAll
            CreateMap<User, SearchAllUsersResponse>()
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.UserName, fonte => fonte.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Phone, fonte => fonte.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Address, fonte => fonte.MapFrom(src => src.Address))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => src.RegisteredAt));

            CreateMap<Product, SearchAllProductsResponse>()
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.Description, fonte => fonte.MapFrom(src => src.Description))
                .ForMember(dest => dest.Brand, fonte => fonte.MapFrom(src => src.Brand))
                .ForMember(dest => dest.SalePrice, fonte => fonte.MapFrom(src => src.SalePrice))
                .ForMember(dest => dest.Storage, fonte => fonte.MapFrom(src => src.Storage))
                .ForMember(dest => dest.RegisteredAt, fonte => fonte.MapFrom(src => src.RegisteredAt));

            CreateMap<Order, SearchAllOrdersResponse>()
                .ForMember(dest => dest.IdOrder, fonte => fonte.MapFrom(src => src.IdOrder))
                .ForMember(dest => dest.IdUser, fonte => fonte.MapFrom(src => src.IdUser))
                .ForMember(dest => dest.PaymentType, fonte => fonte.MapFrom(src => src.PaymentType))
                .ForMember(dest => dest.OrderedItems, fonte => fonte.MapFrom(src => src.OrderedItems))
                .ForMember(dest => dest.ShippingDate, fonte => fonte.MapFrom(src => src.ShippingDate))
                .ForMember(dest => dest.Total, fonte => fonte.MapFrom(src => src.Total))
                .ForMember(dest => dest.OrderedAt, fonte => fonte.MapFrom(src => src.OrderedAt));

            CreateMap<ItemOrder, SearchAllOrderedItemsResponse>()
                .ForMember(dest => dest.IdItemOrder, fonte => fonte.MapFrom(src => src.IdItemOrder))
                .ForMember(dest => dest.IdProduct, fonte => fonte.MapFrom(src => src.IdProduct))
                .ForMember(dest => dest.ProductName, fonte => fonte.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.Quantity, fonte => fonte.MapFrom(src => src.Quantity))
                .ForMember(dest => dest.UnitPrice, fonte => fonte.MapFrom(src => src.UnitPrice));
            #endregion

        }


    }
}
