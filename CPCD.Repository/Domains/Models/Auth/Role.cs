using Microsoft.AspNetCore.Identity;
using System;

namespace CPCD.Repository.Domains.Models;

public class Role : IdentityRole<long>
{
    public Role() : base()
    {
        ConcurrencyStamp = Guid.NewGuid().ToString();
    }

    public Role(string name) : base(name) {
        ConcurrencyStamp = Guid.NewGuid().ToString();
        NormalizedName = name.ToUpper();
    }

    public Role(long id, string name) : this(name)
    {
        Id = id;
    }

    public Role(long id, string name, string stamp) : this(id, name)
    {
        ConcurrencyStamp = stamp;
    }
}
