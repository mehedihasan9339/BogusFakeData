using BogusApiDemo.Models;
using BogusApiDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace BogusApiDemo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly FakeUserService _fakeUserService;

    public UserController(FakeUserService fakeUserService)
    {
        _fakeUserService = fakeUserService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> Get(int count = 10)
    {
        var users = _fakeUserService.GetFakeUsers(count);
        return Ok(users);
    }
}
