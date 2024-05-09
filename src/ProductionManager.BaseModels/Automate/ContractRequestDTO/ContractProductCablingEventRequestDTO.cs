namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductCablingEventGetRequestByGuidDTO(Guid guid);
    public  record ProductCablingEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductCablingEventGetRequestDTO(Object Value);
    public  record ProductCablingEventCreateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductCablingEventUpdateRequestDTO(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductCablingEventDeleteRequestDTO(Guid guid);
}