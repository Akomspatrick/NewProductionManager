namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ModelVersionGetRequestByGuidDTO(Guid guid);
    public  record ModelVersionGetRequestByIdDTO(String EntityNameId);
    public  record ModelVersionGetRequestDTO(Object EntityNameId);
    public  record ModelVersionCreateRequestDTO(Int32  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  modelVersionGroupName, string  defaultTestingMode, DateTime  timestamp, string  userName, Int32  capacity, decimal  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, Int32  minimumDeadLoad, decimal  vMin, Int32  nMax, Int32  safeLoad, Int32  ultimateLoad, string  shellMaterialName, bool  alloy, Int32  defaultCableLength, Int32  numberOfGauges, Int32  resistance, string  cCNumber, string  accuracyClass, string  application, Int32  temperingHardnessLow, Int32  temperingHardnessHigh, string  nTEPCertificationId, DateTime  nTEPCertificationTimestamp, string  oIMLCertificationId, DateTime  oIMLCertificationTimestamp, bool  testPointDirection, Guid  guidId );
    public  record ModelVersionUpdateRequestDTO(Int32  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  modelVersionGroupName, string  defaultTestingMode, DateTime  timestamp, string  userName, Int32  capacity, decimal  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, Int32  minimumDeadLoad, decimal  vMin, Int32  nMax, Int32  safeLoad, Int32  ultimateLoad, string  shellMaterialName, bool  alloy, Int32  defaultCableLength, Int32  numberOfGauges, Int32  resistance, string  cCNumber, string  accuracyClass, string  application, Int32  temperingHardnessLow, Int32  temperingHardnessHigh, string  nTEPCertificationId, DateTime  nTEPCertificationTimestamp, string  oIMLCertificationId, DateTime  oIMLCertificationTimestamp, bool  testPointDirection, Guid  guidId);
    public  record ModelVersionDeleteRequestDTO(Guid guid);
}