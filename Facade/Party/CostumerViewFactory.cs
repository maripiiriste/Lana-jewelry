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
    }

