namespace ProductionManager.Contracts.RequestDTO
{
    public  record LogSummaryGetRequestByGuidDTO(Guid guid);
    public  record LogSummaryGetRequestByIdDTO(String ObjectNameId);
    public  record LogSummaryGetRequestDTO(Object Value);
    public  record LogSummaryCreateRequestDTO(Guid  logSummaryId, string  stage, DateTime  startTime, DateTime  stopTime, string  userName, Int32  noOfItemsProcessed, Guid  guidId );
    public  record LogSummaryUpdateRequestDTO(Guid  logSummaryId, string  stage, DateTime  startTime, DateTime  stopTime, string  userName, Int32  noOfItemsProcessed, Guid  guidId);
    public  record LogSummaryDeleteRequestDTO(Guid guid);
}