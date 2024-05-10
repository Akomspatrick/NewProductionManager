namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record ModelVersionGetRequestByGuidDTO(Guid guid);
    public  record ModelVersionGetRequestByIdDTO(String EntityNameId);
    public  record ModelVersionGetRequestDTO(Object EntityNameId);
    public  record ModelVersionCreateRequestDTO(Int32  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  defaultTestingMode, DateTime  timestamp, string  userName, Int32  capacity, Int32  testCapacity, double  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, Int32  minimumDeadLoad, double  vMin, Int32  nMax, Int32  safeLoad, Int32  ultimateLoad, string  shellMaterialName, Int32  defaultCableLength, Int32  resistance, string  cCNumber, string  accuracyClass, string  application, Guid  guidId );
    public  record ModelVersionUpdateRequestDTO(Int32  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  defaultTestingMode, DateTime  timestamp, string  userName, Int32  capacity, Int32  testCapacity, double  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, Int32  minimumDeadLoad, double  vMin, Int32  nMax, Int32  safeLoad, Int32  ultimateLoad, string  shellMaterialName, Int32  defaultCableLength, Int32  resistance, string  cCNumber, string  accuracyClass, string  application, Guid  guidId);
    public  record ModelVersionDeleteRequestDTO(Guid guid);
}