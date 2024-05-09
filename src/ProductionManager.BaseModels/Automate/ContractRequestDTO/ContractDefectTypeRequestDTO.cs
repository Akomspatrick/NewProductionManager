namespace ProductionManager.Contracts.RequestDTO
{
    public  record DefectTypeGetRequestByGuidDTO(Guid guid);
    public  record DefectTypeGetRequestByIdDTO(String ObjectNameId);
    public  record DefectTypeGetRequestDTO(Object Value);
    public  record DefectTypeCreateRequestDTO(string  defectName, string  stage, string  defectDescription, decimal  triggerPercentage, Int32  minTotalProductInBatchB4Trigger, Guid  guidId );
    public  record DefectTypeUpdateRequestDTO(string  defectName, string  stage, string  defectDescription, decimal  triggerPercentage, Int32  minTotalProductInBatchB4Trigger, Guid  guidId);
    public  record DefectTypeDeleteRequestDTO(Guid guid);
}