namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductCablingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductCablingEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductCablingEventGetRequestDTO(Object EntityNameId);
    public  record ProductCablingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductCablingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductCablingEventDeleteRequestDTO(Guid guid);
}