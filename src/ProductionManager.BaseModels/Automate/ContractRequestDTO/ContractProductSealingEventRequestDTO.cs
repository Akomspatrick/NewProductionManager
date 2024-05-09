namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductSealingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductSealingEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductSealingEventGetRequestDTO(Object Value);
    public  record ProductSealingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductSealingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductSealingEventDeleteRequestDTO(Guid guid);
}