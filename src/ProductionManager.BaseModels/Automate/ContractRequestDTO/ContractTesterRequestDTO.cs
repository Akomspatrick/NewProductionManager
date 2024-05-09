namespace ProductionManager.Contracts.RequestDTO
{
    public  record TesterGetRequestByGuidDTO(Guid guid);
    public  record TesterGetRequestByIdDTO(String ObjectNameId);
    public  record TesterGetRequestDTO(Object Value);
    public  record TesterCreateRequestDTO(string  testerName, Int32  nistTraceAble, Guid  guidId );
    public  record TesterUpdateRequestDTO(string  testerName, Int32  nistTraceAble, Guid  guidId);
    public  record TesterDeleteRequestDTO(Guid guid);
}