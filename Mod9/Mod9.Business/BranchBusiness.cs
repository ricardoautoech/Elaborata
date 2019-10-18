using Mod9.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod9.Business
{
    public class BranchBusiness
    {
        IBranchRepository _repository;
        public BranchBusiness(IBranchRepository repository)
        {
            this._repository = repository;
        }
        public Branches BuscarPeloId(int id)
        {
            Branches objDeRetorno = new Branches();
            try
            {
                objDeRetorno = _repository.BuscarPeloId(id);
            }
            catch (BusinessExceptions bEx)
            {
                bEx.Tratar();
            }
            catch (Exception ex)
            {
                new BusinessExceptions("Erro", ex).Tratar();
            }

            return objDeRetorno;
        }
    }
}
