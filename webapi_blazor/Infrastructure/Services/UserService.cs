public interface IUserService
{
    public Task<dynamic> GetAllAsync();
}

public class UserService : IUserService
{
    public IUnitOfWork _uow;
    public UserService(IUnitOfWork uow) {
        _uow = uow;
    }
    public async Task<dynamic> GetAllAsync()
    {
        var res = await _uow._userRepository.GetAllAsync();
        return new {
            StatusCode= 200,
            Data = res
        };
    }
}
