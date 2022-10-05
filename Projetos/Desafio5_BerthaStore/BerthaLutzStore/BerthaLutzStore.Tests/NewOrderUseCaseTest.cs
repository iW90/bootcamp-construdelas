using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerthaLutzStore.Core.Interfaces;
using Moq;
using BerthaLutzStore.Core.Entities;
using System.Threading.Tasks;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using BerthaLutzStore.Application.Models.NewOrder;

namespace BerthaLutzStore.Tests
{
    [TestClass]
    public class NewOrderUseCaseTest
    {
        [TestMethod]
        public void ExecuteAsync_IfRequestIsNull_ReturnBadRequestResult()
        {
            //Arrange: crio objetos falsos para serem testados
            Mock<IMapper> mapper = new Mock<IMapper>();
            var orderObj = new Order();
            mapper.Setup(x => x.Map<Order>(It.IsAny<NewOrderRequest>()))
                .Returns(orderObj);

            Mock<IOrderRepository> orderRepository = new Mock<IOrderRepository>();
            orderRepository.Setup(x => x.New(It.IsAny<Order>()))
                .Returns(Task.CompletedTask);

            var useCase = new NewOrderUseCase(orderRepository.Object, mapper.Object);

            //Act: executo o método com o objeto-fake
            var resp = useCase.ExecuteAsync(null).Result;

            //Assert: verifico se obtive a resposta esperada
            Assert.IsTrue(resp.GetType() == typeof(BadRequestResult));
        }
    }
}
