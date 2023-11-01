using CPCD.Repository.Domains.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CPCD.API.Managers;

public class AppUserManager<TUser> : UserManager<TUser>
    where TUser : User
{
    public AppUserManager(IUserStore<TUser> store,
        IOptions<IdentityOptions> optionsAccessor,
        IPasswordHasher<TUser> passwordHasher,
        IEnumerable<IUserValidator<TUser>> userValidators,
        IEnumerable<IPasswordValidator<TUser>> passwordValidators,
        ILookupNormalizer keyNormalizer,
        IdentityErrorDescriber errors,
        IServiceProvider services,
        ILogger<UserManager<TUser>> logger) :
        base(store,
            optionsAccessor,
            passwordHasher,
            userValidators,
            passwordValidators,
            keyNormalizer,
            errors,
            services,
            logger)
    {
    }

    public async Task<TUser> FindByPhoneAsync(string phone, CancellationToken cancellationToken = default)
    {
        ThrowIfDisposed();
        return await Users.FirstOrDefaultAsync(u => u.PhoneNumber == phone, cancellationToken);
    }

    public async Task<TUser> FindByIdAsync(long userId)
    {
        ThrowIfDisposed();
        return await Users.FirstOrDefaultAsync(u => u.Id == userId);
    }
}
