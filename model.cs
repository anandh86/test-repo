using System;

namespace SampleApp.Models
{
    /// <summary>
    /// Represents a trade entity with a reference to a unique Trade Id.
    /// </summary>
    public class TradeModel
    {
        /// <summary>
        /// Gets or sets the unique identifier for the trade.
        /// </summary>
        public Guid TradeId { get; set; }

        /// <summary>
        /// Gets or sets the trade date.
        /// </summary>
        public DateTime TradeDate { get; set; }

        /// <summary>
        /// Gets or sets the amount involved in the trade.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency of the trade.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the counterparty to the trade.
        /// </summary>
        public string Counterparty { get; set; }
    }
}
