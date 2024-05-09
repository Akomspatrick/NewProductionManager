namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductSurfacePreparationEventGetRequestByGuidDTO(Guid guid);
    public  record ProductSurfacePreparationEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductSurfacePreparationEventGetRequestDTO(Object Value);
    public  record ProductSurfacePreparationEventCreateRequestDTO(Int32  inspectionResult, string  defectName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductSurfacePreparationEventUpdateRequestDTO(Int32  inspectionResult, string  defectName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductSurfacePreparationEventDeleteRequestDTO(Guid guid);
}