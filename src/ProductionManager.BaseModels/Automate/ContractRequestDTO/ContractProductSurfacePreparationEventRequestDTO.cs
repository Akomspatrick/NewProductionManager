namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductSurfacePreparationEventGetRequestByGuidDTO(Guid guid);
    public  record ProductSurfacePreparationEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductSurfacePreparationEventGetRequestDTO(Object EntityNameId);
    public  record ProductSurfacePreparationEventCreateRequestDTO(Int32  inspectionResult, string  defectName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductSurfacePreparationEventUpdateRequestDTO(Int32  inspectionResult, string  defectName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductSurfacePreparationEventDeleteRequestDTO(Guid guid);
}