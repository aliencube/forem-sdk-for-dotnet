// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Aliencube.Forem.DevTo.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ArticleVideoUser
    {
        /// <summary>
        /// Initializes a new instance of the ArticleVideoUser class.
        /// </summary>
        public ArticleVideoUser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArticleVideoUser class.
        /// </summary>
        /// <param name="name">The user's name</param>
        public ArticleVideoUser(string name = default(string))
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the user's name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
