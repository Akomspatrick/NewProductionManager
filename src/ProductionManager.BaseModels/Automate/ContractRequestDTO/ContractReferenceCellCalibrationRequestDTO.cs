namespace ProductionManager.Contracts.RequestDTO
{
    public  record ReferenceCellCalibrationGetRequestByGuidDTO(Guid guid);
    public  record ReferenceCellCalibrationGetRequestByIdDTO(String ObjectNameId);
    public  record ReferenceCellCalibrationGetRequestDTO(Object Value);
    public  record ReferenceCellCalibrationCreateRequestDTO(Int32  weight, string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, decimal  lowMeasuredPosition, decimal  lowCurrent, decimal  highMeasuredPosition, decimal  highCurrent, Guid  guidId );
    public  record ReferenceCellCalibrationUpdateRequestDTO(Int32  weight, string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, decimal  lowMeasuredPosition, decimal  lowCurrent, decimal  highMeasuredPosition, decimal  highCurrent, Guid  guidId);
    public  record ReferenceCellCalibrationDeleteRequestDTO(Guid guid);
}