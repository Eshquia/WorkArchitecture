using System;
using System.Threading.Tasks;
using Works.Data.Abstract;
using Works.Entities.Dtos;
using Works.Services.Abstract;
using Works.Shared.Utilities.Abstract;
using Works.Shared.Utilities.Concrete;
using Works.Shared.Utilities.Enums;

namespace Works.Services.Concrete
{
    public class WorkService : IWorkService
    {
        private readonly IUnitOfWork _unitOfWork;
        public WorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<WorkDto>> Get(int workId)
        {
            var work = await _unitOfWork.Works.GetAsync(a => a.Id == workId, a => a.Category, a => a.Assignment);
            if (work != null)
            {
                return new DataResult<WorkDto>(ResultStatus.Success, new WorkDto
                {
                    Work = work,
                });
            }
            return new DataResult<WorkDto>(ResultStatus.Error, "Böyle bir work bulunamadı.", null);
        }

        public Task<IResult> Delete(int workId, string modifiedByName)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkDto>> Add(int workId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkListDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkListDto>> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkListDto>> GetAllByNonDeleted()
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkListDto>> GetAllByNonDeletedAndActive()
        {
            throw new NotImplementedException();
        }

        public Task<IResult> HardDelete(int WorkId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(WorkUpdateDto articleUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }



        public Task<IResult> Add(WorkAddDto workAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }
    }
}
