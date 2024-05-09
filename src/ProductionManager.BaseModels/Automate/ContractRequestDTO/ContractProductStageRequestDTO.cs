namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductStageGetRequestByGuidDTO(Guid guid);
    public  record ProductStageGetRequestByIdDTO(String EntityNameId);
    public  record ProductStageGetRequestDTO(Object EntityNameId);
    public  record ProductStageCreateRequestDTO(string  stage, string  stageDescription, Int32  stageNo, string  stageBarcode, string  saveBarCode, string  saveAndEndBarCode, Guid  guidId );
    public  record ProductStageUpdateRequestDTO(string  stage, string  stageDescription, Int32  stageNo, string  stageBarcode, string  saveBarCode, string  saveAndEndBarCode, Guid  guidId);
    public  record ProductStageDeleteRequestDTO(Guid guid);
}