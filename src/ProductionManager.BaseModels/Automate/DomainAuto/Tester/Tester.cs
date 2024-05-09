using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class Tester  : BaseEntity
    {
        private Tester(){}
        public string TesterName    { get; init; }  = string.Empty; 
        public Int32 NistTraceAble    { get; init; } 
        private  List <ProductFinalVerifiationEvent> _ProductFinalVerifiationEvents { get;  set;}  = new List<ProductFinalVerifiationEvent>();
        public  IReadOnlyCollection<ProductFinalVerifiationEvent> ProductFinalVerifiationEvents => _ProductFinalVerifiationEvents;
        private  List <ProductInitialVerificationEvent> _ProductInitialVerificationEvents { get;  set;}  = new List<ProductInitialVerificationEvent>();
        public  IReadOnlyCollection<ProductInitialVerificationEvent> ProductInitialVerificationEvents => _ProductInitialVerificationEvents;
        // public Guid GuidId    { get; init; } 
        
        public static Tester Create(string  testerName, Int32  nistTraceAble, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"Tester Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            TesterName = testerName ,
            NistTraceAble = nistTraceAble ,
            GuidId = guidId ,
        };
    }
    }
}