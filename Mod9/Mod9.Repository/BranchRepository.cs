using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9.Repository
{
    public class BranchRepositorySQLServer : IBranchRepository
    {
        FourthCoffeeEntities contexto = new FourthCoffeeEntities();
        public Branches BuscarPeloId(int id)
        {
            return contexto.Branches.Where(x => x.BranchID == id).SingleOrDefault();
        }
    }

    public class BranchRepositoryOracle : IBranchRepository
    {
        public Branches BuscarPeloId(int id)
        {
            return new Branches();
        }
    }
}
