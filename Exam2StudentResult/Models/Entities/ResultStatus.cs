namespace Exam2StudentResult.Models.Entities
{
    public enum ResultStatus
    {
        All,
        Good,
        Excellent,
        NeedsImprovement
    }
    public enum coursetitle
    {
        CSharp,
        Java,
        Python,
        JavaScript,
        Ruby
    }
    public  class StatusFilter    
    {
        public  ResultStatus resultStatus { get; set; } 

    }
}
