using PizzaAPI.Data.DTOs;
using PizzaAPI.Data.Entities;

namespace PizzaAPI.Data.Interfaces
{
    public interface IAccountRepo
    {
        Task Register(AccountEntity accountEntity);
        Task<AccountEntity> Login(LoginDTO loginDTO);
        Task Update(AccountEntity accountEntity);
    }
}
