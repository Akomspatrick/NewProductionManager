namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductAdditionalInfoGetRequestByGuidDTO(Guid guid);
    public  record ProductAdditionalInfoGetRequestByIdDTO(String EntityNameId);
    public  record ProductAdditionalInfoGetRequestDTO(Object EntityNameId);
    public  record ProductAdditionalInfoCreateRequestDTO(Int32  productAdditionalInfoId, Int32  productId, decimal  inputVoltage, decimal  cableLenght, string  cableLenghtUnit, Guid  guidId );
    public  record ProductAdditionalInfoUpdateRequestDTO(Int32  productAdditionalInfoId, Int32  productId, decimal  inputVoltage, decimal  cableLenght, string  cableLenghtUnit, Guid  guidId);
    public  record ProductAdditionalInfoDeleteRequestDTO(Guid guid);
}