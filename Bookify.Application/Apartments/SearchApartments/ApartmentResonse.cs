﻿
using Bookify.Domain.Apartments;

namespace Bookify.Application.Apartments.SearchApartments;
internal class ApartmentResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Currency { get; set; }
    public AddressResponse Address { get; set; }

}
