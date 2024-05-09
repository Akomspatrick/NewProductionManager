namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductLabellingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductLabellingEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductLabellingEventGetRequestDTO(Object Value);
    public  record ProductLabellingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductLabellingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductLabellingEventDeleteRequestDTO(Guid guid);
}