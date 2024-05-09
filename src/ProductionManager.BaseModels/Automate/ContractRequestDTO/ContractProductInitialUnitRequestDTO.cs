namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductInitialUnitGetRequestByGuidDTO(Guid guid);
    public  record ProductInitialUnitGetRequestByIdDTO(String EntityNameId);
    public  record ProductInitialUnitGetRequestDTO(Object EntityNameId);
    public  record ProductInitialUnitCreateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnits, string  outputUnits, Guid  guidId );
    public  record ProductInitialUnitUpdateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnits, string  outputUnits, Guid  guidId);
    public  record ProductInitialUnitDeleteRequestDTO(Guid guid);
}