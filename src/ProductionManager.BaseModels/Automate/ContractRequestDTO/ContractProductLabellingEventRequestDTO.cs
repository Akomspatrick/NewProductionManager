namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductLabellingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductLabellingEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductLabellingEventGetRequestDTO(Object EntityNameId);
    public  record ProductLabellingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductLabellingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductLabellingEventDeleteRequestDTO(Guid guid);
}