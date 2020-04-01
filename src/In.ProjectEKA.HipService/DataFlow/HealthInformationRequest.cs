namespace In.ProjectEKA.HipService.DataFlow
{
    public class HealthInformationRequest
    {
        public string TransactionId { get; }

        public Consent Consent { get; }

        public HiDataRange HiDataRange { get; }

        public string CallBackUrl { get; }

        public KeyMaterial KeyMaterial { get; }

        public HealthInformationRequest(string transactionId,
            Consent consent,
            HiDataRange hiDataRange,
            string callBackUrl,
            KeyMaterial keyMaterial)
        {
            TransactionId = transactionId;
            Consent = consent;
            HiDataRange = hiDataRange;
            CallBackUrl = callBackUrl;
            KeyMaterial = keyMaterial;
        }
    }
}