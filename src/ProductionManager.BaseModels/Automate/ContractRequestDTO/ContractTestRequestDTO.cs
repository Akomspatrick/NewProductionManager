namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record TestGetRequestByGuidDTO(Guid guid);
    public  record TestGetRequestByIdDTO(String EntityNameId);
    public  record TestGetRequestDTO(Object EntityNameId);
    public  record TestCreateRequestDTO(DateTime  timestamp, Int32  productId, string  userName, string  refStandardSerialNo, string  refStandardManufacturer, string  refStandardModelName, decimal  excitationResistance, decimal  signalResistance, Guid  guidId );
    public  record TestUpdateRequestDTO(DateTime  timestamp, Int32  productId, string  userName, string  refStandardSerialNo, string  refStandardManufacturer, string  refStandardModelName, decimal  excitationResistance, decimal  signalResistance, Guid  guidId);
    public  record TestDeleteRequestDTO(Guid guid);
}