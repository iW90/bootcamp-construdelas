using BerthaLutzStore.Application.Models.NewUser;
using BerthaLutzStore.Application.Models.UpdateUser;
using BerthaLutzStore.Application.Models.DeleteUser;
using BerthaLutzStore.Application.Models.SearchUser;
using BerthaLutzStore.Application.Models.SearchAllUsers;
using BerthaLutzStore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        private readonly IUseCaseAsync<SearchAllUsersRequest, IActionResult> _searchAllUsersCaseAsync;

        public UserController(
            IUseCaseAsync<NewUserRequest, IActionResult> newUserCaseAsync,
            IUseCaseAsync<UpdateUserRequest, IActionResult> updateUserCaseAsync,
            IUseCaseAsync<DeleteUserRequest, IActionResult> deleteUserCaseAsync,
            IUseCaseAsync<SearchUserRequest, IActionResult> searchUserCaseAsync,
            IUseCaseAsync<SearchAllUsersRequest, IActionResult> searchAllUsersCaseAsync)
        {
            _newUserCaseAsync = newUserCaseAsync;
            _updateUserCaseAsync = updateUserCaseAsync;
            _deleteUserCaseAsync = deleteUserCaseAsync;
            _searchUserCaseAsync = searchUserCaseAsync;
            _searchAllUsersCaseAsync = searchAllUsersCaseAsync;
        }

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
        [HttpDelete]
        public async Task<IActionResult> Put([FromBody] DeleteUserRequest request)
        {
            return await _deleteUserCaseAsync.ExecuteAsync(request);
        }

        //Search User by Id
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            return await _searchUserCaseAsync.ExecuteAsync(new SearchUserRequest() { IdUser = id });
        }

        ////Search All Users
        //[HttpGet("All")]
        //public async Task<IActionResult<List<SearchAllUsersResponse>>> Get([FromQuery] SearchAllUsersRequest request)
        //{
        //    return await _searchAllUsersCaseAsync.ExecuteAsync(request);
        //}
    }
}
