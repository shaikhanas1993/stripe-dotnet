namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardCreateOptions : INestedOptions
    {
        /// <summary>
        /// Card security code. It is highly recommended to always include this value.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        /// <summary>
        /// Two-digit number representing the card's expiration month.
        /// </summary>
        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        /// <summary>
        /// Two- or four-digit number representing the card's expiration year.
        /// </summary>
        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// The card number, as a string without any separators.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// For backwards compatibility, you can  provide a Stripe token (e.g., for Apple Pay,
        /// or legacy Checkout).
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
