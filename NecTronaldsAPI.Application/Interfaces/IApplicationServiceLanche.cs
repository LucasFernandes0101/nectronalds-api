using NecTronaldsAPI.Application.Dtos;
using System.Collections.Generic;

namespace NecTronaldsAPI.Application.Interfaces
{
    public interface IApplicationServiceLanche
    {
        void Add(LancheDto lancheDto);
        void Update(LancheDto lancheDto);
        void Delete(LancheDto lancheDto);
        IEnumerable<LancheDto> GetAll();
        LancheDto GetById(int id);
    }
}
