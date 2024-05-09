namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductResistorInstallationEventGetRequestByGuidDTO(Guid guid);
    public  record ProductResistorInstallationEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductResistorInstallationEventGetRequestDTO(Object Value);
    public  record ProductResistorInstallationEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductResistorInstallationEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductResistorInstallationEventDeleteRequestDTO(Guid guid);
}