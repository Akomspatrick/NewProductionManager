using ProductionManager.Contracts.RequestDTO.V1;
using ProductionManager.Contracts.ResponseDTO.V1;
using ProductionManager.Domain.Errors;
using LanguageExt;
using MediatR;
namespace ProductionManager.Application.CQRS{
    public  record GetTestQuery(TestGetRequestDTO  RequestTestDTO) :  IRequest<Either<GeneralFailure, TestResponseDTO>>;
    public  record GetTestByGuidQuery(TestGetRequestByGuidDTO  RequestTestDTO) :  IRequest<Either<GeneralFailure, TestResponseDTO>>;
    public  record GetTestByIdQuery(TestGetRequestByIdDTO  RequestTestDTO) :  IRequest<Either<GeneralFailure, TestResponseDTO>>;
    public  record GetAllTestQuery :  IRequest<Either<GeneralFailure, IEnumerable<TestResponseDTO>>>;
}