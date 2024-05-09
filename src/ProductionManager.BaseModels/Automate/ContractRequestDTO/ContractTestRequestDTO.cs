namespace ProductionManager.Contracts.RequestDTO
{
    public  record TestGetRequestByGuidDTO(Guid guid);
    public  record TestGetRequestByIdDTO(String ObjectNameId);
    public  record TestGetRequestDTO(Object Value);
    public  record TestCreateRequestDTO(DateTime  timestamp, Int32  productId, string  userName, string  refStandardSerialNo, string  refStandardManufacturer, string  refStandardModelName, decimal  excitationResistance, decimal  signalResistance, Guid  guidId );
    public  record TestUpdateRequestDTO(DateTime  timestamp, Int32  productId, string  userName, string  refStandardSerialNo, string  refStandardManufacturer, string  refStandardModelName, decimal  excitationResistance, decimal  signalResistance, Guid  guidId);
    public  record TestDeleteRequestDTO(Guid guid);
}