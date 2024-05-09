namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductShippingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductShippingEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductShippingEventGetRequestDTO(Object EntityNameId);
    public  record ProductShippingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductShippingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductShippingEventDeleteRequestDTO(Guid guid);
}