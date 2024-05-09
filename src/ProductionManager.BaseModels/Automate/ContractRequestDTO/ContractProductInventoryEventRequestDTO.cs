namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductInventoryEventGetRequestByGuidDTO(Guid guid);
    public  record ProductInventoryEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductInventoryEventGetRequestDTO(Object EntityNameId);
    public  record ProductInventoryEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductInventoryEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductInventoryEventDeleteRequestDTO(Guid guid);
}