using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Application.Models.SearchAllUsers;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BerthaStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //desacomplamento de código
        private readonly IUseCaseAsync<NewUserRequest, IActionResult> _newUserCaseAsync;
        private readonly IUseCaseAsync<SearchUserRequest, IActionResult> _searchUserCaseAsync;
        private readonly IUseCaseAsync<UpdateUserRequest, IActionResult> _updateUserCaseAsync;
        private readonly DeleteUserUseCase _deleteUserCaseAsync;
        private readonly IUseCaseAsync<SearchAllUsersRequest, IActionResult> _searchAllUsersCaseAsync;

        public UserController(
            IUseCaseAsync<NewUserRequest, IActionResult> newUserCaseAsync,
            IUseCaseAsync<SearchUserRequest, IActionResult> searchUserCaseAsync,
            IUseCaseAsync<UpdateUserRequest, IActionResult> updateUserCaseAsync,
            DeleteUserUseCase deleteUserCaseAsync,
            IUseCaseAsync<SearchAllUsersRequest, IActionResult> searchAllUsersCaseAsync)
        {
            _newUserCaseAsync = newUserCaseAsync;
            _searchUserCaseAsync = searchUserCaseAsync;
            _updateUserCaseAsync = updateUserCaseAsync;
            _deleteUserCaseAsync = deleteUserCaseAsync;
            _searchAllUsersCaseAsync = searchAllUsersCaseAsync;
        }

        //Requisições HTTP
        //New User
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewUserRequest request)
        {
            return await _newUserCaseAsync.ExecuteAsync(request);
        }

        //Update User by Id
        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateUserRequest request)
        {
            return await _updateUserCaseAsync.ExecuteAsync(request);
        }

        //Delete User by Id
        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete([FromRoute] int userId)
        {
            return await _deleteUserCaseAsync.ExecuteAsync(userId);
        }

        //Search User by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] SearchUserRequest request)
        {
            return await _searchUserCaseAsync.ExecuteAsync(request);
        }

        //Search All Users
        [HttpGet("ListAll")]
        public async Task<IActionResult> Get([FromQuery] SearchAllUsersRequest request)
        {
            return await _searchAllUsersCaseAsync.ExecuteAsync(request);
        }
    }
}
