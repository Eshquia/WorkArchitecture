using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Entities.Dtos;
using Works.Shared.Utilities.Abstract;

namespace Works.Services.Abstract
{
   public interface IWorkService
    {
        Task<IDataResult<WorkDto>> Get(int workId);
        Task<IDataResult<WorkListDto>> GetAll();
        Task<IDataResult<WorkListDto>> GetAllByNonDeleted();
        Task<IDataResult<WorkListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<WorkListDto>> GetAllByCategory(int categoryId);
        Task<IResult> Add(WorkAddDto workAddDto, string createdByName);
        Task<IResult> Update(WorkUpdateDto articleUpdateDto, string modifiedByName);
        Task<IResult> Delete(int workId, string modifiedByName);
        Task<IResult> HardDelete(int WorkId);
    }
}
