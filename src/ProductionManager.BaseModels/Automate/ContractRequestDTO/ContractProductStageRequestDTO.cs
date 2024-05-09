namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductStageGetRequestByGuidDTO(Guid guid);
    public  record ProductStageGetRequestByIdDTO(String ObjectNameId);
    public  record ProductStageGetRequestDTO(Object Value);
    public  record ProductStageCreateRequestDTO(string  stage, string  stageDescription, Int32  stageNo, string  stageBarcode, string  saveBarCode, string  saveAndEndBarCode, Guid  guidId );
    public  record ProductStageUpdateRequestDTO(string  stage, string  stageDescription, Int32  stageNo, string  stageBarcode, string  saveBarCode, string  saveAndEndBarCode, Guid  guidId);
    public  record ProductStageDeleteRequestDTO(Guid guid);
}