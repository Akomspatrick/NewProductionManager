namespace ProductionManager.Contracts.RequestDTO
{
    public  record LogDetailGetRequestByGuidDTO(Guid guid);
    public  record LogDetailGetRequestByIdDTO(String ObjectNameId);
    public  record LogDetailGetRequestDTO(Object Value);
    public  record LogDetailCreateRequestDTO(Int32  productId, Guid  logSummaryId, Guid  guidId );
    public  record LogDetailUpdateRequestDTO(Int32  productId, Guid  logSummaryId, Guid  guidId);
    public  record LogDetailDeleteRequestDTO(Guid guid);
}