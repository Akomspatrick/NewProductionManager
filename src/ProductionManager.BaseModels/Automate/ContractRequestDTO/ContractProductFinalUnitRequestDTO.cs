namespace ProductionManager.Contracts.RequestDTO
{
    public  record ProductFinalUnitGetRequestByGuidDTO(Guid guid);
    public  record ProductFinalUnitGetRequestByIdDTO(String ObjectNameId);
    public  record ProductFinalUnitGetRequestDTO(Object Value);
    public  record ProductFinalUnitCreateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnit, string  ouputUnits, string  indicatorType, Int32  indicatorChannel, string  indicatorSerialNo, Int32  gradSize, decimal  pinSize, Int32  division, decimal  lowWeight, decimal  highWeight, Guid  guidId );
    public  record ProductFinalUnitUpdateRequestDTO(Int32  productId, DateTime  timeStamp, string  inputUnit, string  ouputUnits, string  indicatorType, Int32  indicatorChannel, string  indicatorSerialNo, Int32  gradSize, decimal  pinSize, Int32  division, decimal  lowWeight, decimal  highWeight, Guid  guidId);
    public  record ProductFinalUnitDeleteRequestDTO(Guid guid);
}