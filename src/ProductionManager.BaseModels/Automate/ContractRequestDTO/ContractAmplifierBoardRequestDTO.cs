namespace ProductionManager.Contracts.RequestDTO
{
    public  record AmplifierBoardGetRequestByGuidDTO(Guid guid);
    public  record AmplifierBoardGetRequestByIdDTO(String ObjectNameId);
    public  record AmplifierBoardGetRequestDTO(Object Value);
    public  record AmplifierBoardCreateRequestDTO(Int32  amplifierBoardId, string  brand, string  name, Int32  hasRed, string  redValue, Int32  hasGreen, string  greenValue, Int32  hasBlack, string  blackValue, Int32  hasWhite, string  whiteValue, Int32  hasShield, string  shieldValue, Guid  guidId );
    public  record AmplifierBoardUpdateRequestDTO(Int32  amplifierBoardId, string  brand, string  name, Int32  hasRed, string  redValue, Int32  hasGreen, string  greenValue, Int32  hasBlack, string  blackValue, Int32  hasWhite, string  whiteValue, Int32  hasShield, string  shieldValue, Guid  guidId);
    public  record AmplifierBoardDeleteRequestDTO(Guid guid);
}