using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class AmplifierBoard  : BaseEntity
    {
        private AmplifierBoard(){}
        public Int32 AmplifierBoardId    { get; init; } 
        public string Brand    { get; init; }  = string.Empty; 
        public string Name    { get; init; }  = string.Empty; 
        public Int32 HasRed    { get; init; } 
        public string RedValue    { get; init; }  = string.Empty; 
        public Int32 HasGreen    { get; init; } 
        public string GreenValue    { get; init; }  = string.Empty; 
        public Int32 HasBlack    { get; init; } 
        public string BlackValue    { get; init; }  = string.Empty; 
        public Int32 HasWhite    { get; init; } 
        public string WhiteValue    { get; init; }  = string.Empty; 
        public Int32 HasShield    { get; init; } 
        public string ShieldValue    { get; init; }  = string.Empty; 
        public Guid GuidId    { get; init; } 
        
        public static AmplifierBoard Create(Int32  amplifierBoardId, string  brand, string  name, Int32  hasRed, string  redValue, Int32  hasGreen, string  greenValue, Int32  hasBlack, string  blackValue, Int32  hasWhite, string  whiteValue, Int32  hasShield, string  shieldValue, Guid  guidId)
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