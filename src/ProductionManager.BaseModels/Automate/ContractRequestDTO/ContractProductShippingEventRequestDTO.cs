namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductShippingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductShippingEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductShippingEventGetRequestDTO(Object Value);
    public  record ProductShippingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductShippingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductShippingEventDeleteRequestDTO(Guid guid);
}