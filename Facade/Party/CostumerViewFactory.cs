using Lana_jewelry.Data.Party;
using Lana_jewelry.Domain.Party;

namespace Lana_jewelry.Facade.Party
{
    public class CostumerViewFactory
    {
        public Costumer Create(CostumerView v) => new(new CostumerData { 
                Id = v.Id,
                DoB = v.DoB,
                FirstName = v.FirstName,
                LastName = v.LastName,
                Email = v.Email
            });

        public CostumerView Create(Costumer o) => new() {
                Id = o.Id,
                DoB = o.DoB,
                FirstName = o.FirstName,
                LastName = o.LastName,
                Email = o.Email
            };
        }
    
    public class InfoViewFactory {
        public Info Create(InfoView v) => new(new InfoData {
            Id = v.Id,
            Country = v.Country,
            City = v.City,
            Region = v.Region,
            Street = v.Street,
            StreetNumber=v.StreetNumber,
            ZipCode = v.ZipCode,
            EmailAddress = v.EmailAddress,
            PhoneNumber = v.PhoneNumber,
        });

        public InfoView Create(Info o) => new() {
            Id = o.Id,
            Country = o.Country,
            City = o.City,
            Region = o.Region,
            Street = o.Street,
            StreetNumber = o.StreetNumber,
            ZipCode = o.ZipCode,
            EmailAddress = o.EmailAddress,
            PhoneNumber = o.PhoneNumber,
        };
    }
}


