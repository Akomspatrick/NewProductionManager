using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class AmplifierBoard  : BaseEntity
    {
        private AmplifierBoard(){}
        public int AmplifierBoardId    { get; init; } 
        public string Brand    { get; init; }  = string.Empty; 
        public string Name    { get; init; }  = string.Empty; 
        public int HasRed    { get; init; } 
        public string RedValue    { get; init; }  = string.Empty; 
        public int HasGreen    { get; init; } 
        public string GreenValue    { get; init; }  = string.Empty; 
        public int HasBlack    { get; init; } 
        public string BlackValue    { get; init; }  = string.Empty; 
        public int HasWhite    { get; init; } 
        public string WhiteValue    { get; init; }  = string.Empty; 
        public int HasShield    { get; init; } 
        public string ShieldValue    { get; init; }  = string.Empty; 
        public Guid GuidId    { get; init; } 
        
        public static AmplifierBoard Create(int  amplifierBoardId, string  brand, string  name, int  hasRed, string  redValue, int  hasGreen, string  greenValue, int  hasBlack, string  blackValue, int  hasWhite, string  whiteValue, int  hasShield, string  shieldValue, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"AmplifierBoard Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            AmplifierBoardId = amplifierBoardId ,
            Brand = brand ,
            Name = name ,
            HasRed = hasRed ,
            RedValue = redValue ,
            HasGreen = hasGreen ,
            GreenValue = greenValue ,
            HasBlack = hasBlack ,
            BlackValue = blackValue ,
            HasWhite = hasWhite ,
            WhiteValue = whiteValue ,
            HasShield = hasShield ,
            ShieldValue = shieldValue ,
            GuidId = guidId ,
        };
    }
    }
}