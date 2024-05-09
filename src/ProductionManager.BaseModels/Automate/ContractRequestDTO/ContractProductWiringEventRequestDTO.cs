namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductWiringEventGetRequestByGuidDTO(Guid guid);
    public  record ProductWiringEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductWiringEventGetRequestDTO(Object EntityNameId);
    public  record ProductWiringEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductWiringEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductWiringEventDeleteRequestDTO(Guid guid);
}