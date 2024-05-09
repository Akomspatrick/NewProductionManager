namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ProductInitialVerificationEventGetRequestByGuidDTO(Guid guid);
    public  record ProductInitialVerificationEventGetRequestByIdDTO(String EntityNameId);
    public  record ProductInitialVerificationEventGetRequestDTO(Object EntityNameId);
    public  record ProductInitialVerificationEventCreateRequestDTO(Int32  points, Int32  verificationResult, string  referenceSerial, string  testerName, decimal  calibratedOutput, decimal  percentNonlinearity, decimal  dutZeroPoint, decimal  refPoint1, decimal  forcePoint1, decimal  dutPoint1, decimal  refPoint2, decimal  forcePoint2, decimal  dutPoint2, decimal  refPoint3, decimal  forcePoint3, decimal  dutPoint3, decimal  refPoint4, decimal  forcePoint4, decimal  dutPoint4, decimal  refPoint5, decimal  forcePoint5, decimal  dutPoint5, decimal  refPoint6, decimal  forcePoint6, decimal  dutPoint6, decimal  refPoint7, decimal  forcePoint7, decimal  dutPoint7, decimal  refPoint8, decimal  forcePoint8, decimal  dutPoint8, decimal  refPoint9, decimal  forcePoint9, decimal  dutPoint9, decimal  refPoint10, decimal  forcePoint10, decimal  dutPoint10, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId );
    public  record ProductInitialVerificationEventUpdateRequestDTO(Int32  points, Int32  verificationResult, string  referenceSerial, string  testerName, decimal  calibratedOutput, decimal  percentNonlinearity, decimal  dutZeroPoint, decimal  refPoint1, decimal  forcePoint1, decimal  dutPoint1, decimal  refPoint2, decimal  forcePoint2, decimal  dutPoint2, decimal  refPoint3, decimal  forcePoint3, decimal  dutPoint3, decimal  refPoint4, decimal  forcePoint4, decimal  dutPoint4, decimal  refPoint5, decimal  forcePoint5, decimal  dutPoint5, decimal  refPoint6, decimal  forcePoint6, decimal  dutPoint6, decimal  refPoint7, decimal  forcePoint7, decimal  dutPoint7, decimal  refPoint8, decimal  forcePoint8, decimal  dutPoint8, decimal  refPoint9, decimal  forcePoint9, decimal  dutPoint9, decimal  refPoint10, decimal  forcePoint10, decimal  dutPoint10, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId);
    public  record ProductInitialVerificationEventDeleteRequestDTO(Guid guid);
}