namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductReceptionEventGetRequestByGuidDTO(Guid guid);
    public  record ProductReceptionEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductReceptionEventGetRequestDTO(Object EntityNameId);
    public  record ProductReceptionEventCreateRequestDTO(string  notes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductReceptionEventUpdateRequestDTO(string  notes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductReceptionEventDeleteRequestDTO(Guid guid);
}