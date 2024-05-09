namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductFinishedEventGetRequestByGuidDTO(Guid guid);
    public  record ProductFinishedEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductFinishedEventGetRequestDTO(Object Value);
    public  record ProductFinishedEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductFinishedEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductFinishedEventDeleteRequestDTO(Guid guid);
}