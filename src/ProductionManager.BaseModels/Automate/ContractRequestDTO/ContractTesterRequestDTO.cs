namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record TesterGetRequestByGuidDTO(Guid guid);
    public  record TesterGetRequestByIdDTO(String EntityNameId);
    public  record TesterGetRequestDTO(Object EntityNameId);
    public  record TesterCreateRequestDTO(string  testerName, Int32  nistTraceAble, Guid  guidId );
    public  record TesterUpdateRequestDTO(string  testerName, Int32  nistTraceAble, Guid  guidId);
    public  record TesterDeleteRequestDTO(Guid guid);
}