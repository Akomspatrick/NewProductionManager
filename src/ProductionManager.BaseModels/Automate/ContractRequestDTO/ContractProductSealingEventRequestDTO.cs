namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductSealingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductSealingEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductSealingEventGetRequestDTO(Object EntityNameId);
    public  record ProductSealingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductSealingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductSealingEventDeleteRequestDTO(Guid guid);
}