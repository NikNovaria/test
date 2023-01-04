namespace WSTxDoc.Models
{

    //Classe utilizzata per il response delle API
    public class ResponseClass
    {
        public int StatusCode { get; set; } = 0;
        public string Body { get; set; } = string.Empty;
    }
}
