namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record DefectTypeGetRequestByGuidDTO(Guid guid);
    public  record DefectTypeGetRequestByIdDTO(String EntityNameId);
    public  record DefectTypeGetRequestDTO(Object EntityNameId);
    public  record DefectTypeCreateRequestDTO(string  defectName, string  stage, string  defectDescription, decimal  triggerPercentage, Int32  minTotalProductInBatchB4Trigger, Guid  guidId );
    public  record DefectTypeUpdateRequestDTO(string  defectName, string  stage, string  defectDescription, decimal  triggerPercentage, Int32  minTotalProductInBatchB4Trigger, Guid  guidId);
    public  record DefectTypeDeleteRequestDTO(Guid guid);
}