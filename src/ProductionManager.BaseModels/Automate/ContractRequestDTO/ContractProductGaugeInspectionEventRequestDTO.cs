namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductGaugeInspectionEventGetRequestByGuidDTO(Guid guid);
    public  record ProductGaugeInspectionEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductGaugeInspectionEventGetRequestDTO(Object Value);
    public  record ProductGaugeInspectionEventCreateRequestDTO(Int32  inspectionResult, string  defectName, Int32  gaugeFailed, Int32  gaugePassed, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductGaugeInspectionEventUpdateRequestDTO(Int32  inspectionResult, string  defectName, Int32  gaugeFailed, Int32  gaugePassed, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductGaugeInspectionEventDeleteRequestDTO(Guid guid);
}