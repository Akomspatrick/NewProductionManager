namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductInventoryEventGetRequestByGuidDTO(Guid guid);
    public  record ProductInventoryEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductInventoryEventGetRequestDTO(Object Value);
    public  record ProductInventoryEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductInventoryEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductInventoryEventDeleteRequestDTO(Guid guid);
}