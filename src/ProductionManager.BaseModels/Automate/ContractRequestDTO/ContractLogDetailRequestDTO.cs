namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record LogDetailGetRequestByGuidDTO(Guid guid);
    public  record LogDetailGetRequestByIdDTO(String EntityNameId);
    public  record LogDetailGetRequestDTO(Object EntityNameId);
    public  record LogDetailCreateRequestDTO(Int32  productId, Guid  logSummaryId, Guid  guidId );
    public  record LogDetailUpdateRequestDTO(Int32  productId, Guid  logSummaryId, Guid  guidId);
    public  record LogDetailDeleteRequestDTO(Guid guid);
}