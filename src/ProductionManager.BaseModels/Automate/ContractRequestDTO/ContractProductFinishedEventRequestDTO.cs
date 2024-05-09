namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductFinishedEventGetRequestByGuidDTO(Guid guid);
    public  record ProductFinishedEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductFinishedEventGetRequestDTO(Object EntityNameId);
    public  record ProductFinishedEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductFinishedEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductFinishedEventDeleteRequestDTO(Guid guid);
}