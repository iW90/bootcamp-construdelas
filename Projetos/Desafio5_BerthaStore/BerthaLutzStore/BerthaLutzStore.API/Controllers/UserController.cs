using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Application.Models.SearchUser;
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
        private readonly IUseCaseAsync<NewUserRequest, IActionResult> _newUserCaseAsync;
        private readonly IUseCaseAsync<UpdateUserRequest, IActionResult> _updateUserCaseAsync;
        private readonly IUseCaseAsync<DeleteUserRequest, IActionResult> _deleteUserCaseAsync;
        private readonly IUseCaseAsync<SearchUserRequest, IActionResult> _searchUserCaseAsync;
        //private readonly IUseCaseAsync<SearchAllUsersRequest, IActionResult> _searchAllUsersCaseAsync;

        public UserController(
            IUseCaseAsync<NewUserRequest, IActionResult> newUserCaseAsync,
            IUseCaseAsync<UpdateUserRequest, IActionResult> updateUserCaseAsync,
            IUseCaseAsync<DeleteUserRequest, IActionResult> deleteUserCaseAsync,
            IUseCaseAsync<SearchUserRequest, IActionResult> searchUserCaseAsync)
            //IUseCaseAsync<SearchAllUsersRequest, IActionResult> searchAllUsersCaseAsync)
        {
            _newUserCaseAsync = newUserCaseAsync;
            _updateUserCaseAsync = updateUserCaseAsync;
            _deleteUserCaseAsync = deleteUserCaseAsync;
            _searchUserCaseAsync = searchUserCaseAsync;
            //_searchAllUsersCaseAsync = searchAllUsersCaseAsync;
        }

        //New User
        [HttpPost("NewUser")]
        public async Task<IActionResult> Post([FromBody] NewUserRequest request)
        {
            return await _newUserCaseAsync.ExecuteAsync(request);
        }

        //Update User by Id
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> Put([FromBody] UpdateUserRequest request)
        {
            return await _updateUserCaseAsync.ExecuteAsync(request);
        }

        //Delete User by Id
        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> Delete([FromRoute] DeleteUserRequest request)
        {
            var userId = await _deleteUserCaseAsync.ExecuteAsync(request);
            if (userId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(userId);
        }

        //Search User by Id
        [HttpGet("SearchUser")]
        public async Task<IActionResult> Get([FromQuery] SearchUserRequest request)
        {
            var userId = await _searchUserCaseAsync.ExecuteAsync(request);
            if (userId == null)
                return new NotFoundObjectResult("Id not found");
            return new OkObjectResult(userId);
        }

        //Search All Users
        //[HttpGet("SearchAllUsers")]
        //public async Task<IActionResult<List<SearchAllUsersResponse>>> Get([FromQuery] SearchAllUsersRequest request)
        //{
        //    return await _searchAllUsersCaseAsync.ExecuteAsync(request);
        //}
    }
}
