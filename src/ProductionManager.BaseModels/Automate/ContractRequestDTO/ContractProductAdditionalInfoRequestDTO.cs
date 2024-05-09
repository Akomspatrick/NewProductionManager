namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductAdditionalInfoGetRequestByGuidDTO(Guid guid);
    public  record ProductAdditionalInfoGetRequestByIdDTO(String ObjectNameId);
    public  record ProductAdditionalInfoGetRequestDTO(Object Value);
    public  record ProductAdditionalInfoCreateRequestDTO(Int32  productAdditionalInfoId, Int32  productId, decimal  inputVoltage, decimal  cableLenght, string  cableLenghtUnit, Guid  guidId );
    public  record ProductAdditionalInfoUpdateRequestDTO(Int32  productAdditionalInfoId, Int32  productId, decimal  inputVoltage, decimal  cableLenght, string  cableLenghtUnit, Guid  guidId);
    public  record ProductAdditionalInfoDeleteRequestDTO(Guid guid);
}