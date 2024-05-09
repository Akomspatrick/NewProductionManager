namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductResistorInstallationEventGetRequestByGuidDTO(Guid guid);
    public  record ProductResistorInstallationEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductResistorInstallationEventGetRequestDTO(Object EntityNameId);
    public  record ProductResistorInstallationEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductResistorInstallationEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductResistorInstallationEventDeleteRequestDTO(Guid guid);
}