namespace ProductionManager.Contracts.RequestDTO
{
    public  record ReferenceStandardGetRequestByGuidDTO(Guid guid);
    public  record ReferenceStandardGetRequestByIdDTO(String ObjectNameId);
    public  record ReferenceStandardGetRequestDTO(Object Value);
    public  record ReferenceStandardCreateRequestDTO(string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, Int32  capacity, DateTime  timestamp, decimal  b0, decimal  b1, decimal  b2, decimal  b3, decimal  b4, Guid  guidId );
    public  record ReferenceStandardUpdateRequestDTO(string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, Int32  capacity, DateTime  timestamp, decimal  b0, decimal  b1, decimal  b2, decimal  b3, decimal  b4, Guid  guidId);
    public  record ReferenceStandardDeleteRequestDTO(Guid guid);
}