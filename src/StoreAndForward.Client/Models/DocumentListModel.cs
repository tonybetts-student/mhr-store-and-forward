// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace DigitalHealth.StoreAndForward.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Document list model.
    /// </summary>
    public partial class DocumentListModel
    {
        /// <summary>
        /// Initializes a new instance of the DocumentListModel class.
        /// </summary>
        public DocumentListModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DocumentListModel class.
        /// </summary>
        /// <param name="total">Total.</param>
        /// <param name="limit">Limit.</param>
        /// <param name="offset">Offset.</param>
        /// <param name="documents">Document list.</param>
        public DocumentListModel(int? total = default(int?), int? limit = default(int?), int? offset = default(int?), IList<DocumentReferenceModel> documents = default(IList<DocumentReferenceModel>))
        {
            Total = total;
            Limit = limit;
            Offset = offset;
            Documents = documents;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }

        /// <summary>
        /// Gets or sets limit.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets offset.
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or sets document list.
        /// </summary>
        [JsonProperty(PropertyName = "documents")]
        public IList<DocumentReferenceModel> Documents { get; set; }

    }
}
