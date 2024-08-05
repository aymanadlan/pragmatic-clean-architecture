﻿
using Bookify.Domain.Apartments;

namespace Bookify.Infrastructure.Repositories;

public class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbcontext) : base(dbcontext)
    {
    }
}
