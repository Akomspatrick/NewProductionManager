namespace ProductionManager.Contracts.RequestDTO.V1
{
    public  record AmplifierBoardGetRequestByGuidDTO(Guid guid);
    public  record AmplifierBoardGetRequestByIdDTO(String EntityNameId);
    public  record AmplifierBoardGetRequestDTO(Object EntityNameId);
    public  record AmplifierBoardCreateRequestDTO(Int32  amplifierBoardId, string  brand, string  name, Int32  hasRed, string  redValue, Int32  hasGreen, string  greenValue, Int32  hasBlack, string  blackValue, Int32  hasWhite, string  whiteValue, Int32  hasShield, string  shieldValue, Guid  guidId );
    public  record AmplifierBoardUpdateRequestDTO(Int32  amplifierBoardId, string  brand, string  name, Int32  hasRed, string  redValue, Int32  hasGreen, string  greenValue, Int32  hasBlack, string  blackValue, Int32  hasWhite, string  whiteValue, Int32  hasShield, string  shieldValue, Guid  guidId);
    public  record AmplifierBoardDeleteRequestDTO(Guid guid);
}