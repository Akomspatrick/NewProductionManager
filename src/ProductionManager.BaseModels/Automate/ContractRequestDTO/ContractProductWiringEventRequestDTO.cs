namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductWiringEventGetRequestByGuidDTO(Guid guid);
    public  record ProductWiringEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductWiringEventGetRequestDTO(Object Value);
    public  record ProductWiringEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductWiringEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductWiringEventDeleteRequestDTO(Guid guid);
}