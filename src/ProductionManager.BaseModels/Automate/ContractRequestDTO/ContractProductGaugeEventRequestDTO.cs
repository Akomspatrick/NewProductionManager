namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductGaugeEventGetRequestByGuidDTO(Guid guid);
    public  record ProductGaugeEventGetRequestByIdDTO(String ObjectNameId);
    public  record ProductGaugeEventGetRequestDTO(Object Value);
    public  record ProductGaugeEventCreateRequestDTO(string  guageModel, string  guageLotNo, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductGaugeEventUpdateRequestDTO(string  guageModel, string  guageLotNo, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductGaugeEventDeleteRequestDTO(Guid guid);
}