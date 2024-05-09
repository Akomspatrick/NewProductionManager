namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record LogSummaryGetRequestByGuidDTO(Guid guid);
    public  record LogSummaryGetRequestByIdDTO(String EntityNameId);
    public  record LogSummaryGetRequestDTO(Object EntityNameId);
    public  record LogSummaryCreateRequestDTO(Guid  logSummaryId, string  stage, DateTime  startTime, DateTime  stopTime, string  userName, Int32  noOfItemsProcessed, Guid  guidId );
    public  record LogSummaryUpdateRequestDTO(Guid  logSummaryId, string  stage, DateTime  startTime, DateTime  stopTime, string  userName, Int32  noOfItemsProcessed, Guid  guidId);
    public  record LogSummaryDeleteRequestDTO(Guid guid);
}