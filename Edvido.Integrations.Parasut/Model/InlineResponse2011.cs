
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Edvido.Integrations.Parasut.Model
{
    /// <summary>
    /// InlineResponse2011
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011 :  IEquatable<InlineResponse2011>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011" /> class.
        /// </summary>
        /// <param name="Data">Data.</param>
        /// <param name="Included">Included.</param>
        public InlineResponse2011(InlineResponse2011Data Data = default(InlineResponse2011Data), List<InlineResponse2011Included> Included = default(List<InlineResponse2011Included>))
        {
            this.Data = Data;
            this.Included = Included;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public InlineResponse2011Data Data { get; set; }
        /// <summary>
        /// Gets or Sets Included
        /// </summary>
        [DataMember(Name="included", EmitDefaultValue=false)]
        public List<InlineResponse2011Included> Included { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Included: ").Append(Included).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as InlineResponse2011);
        }

        /// <summary>
        /// Returns true if InlineResponse2011 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2011 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.Included == other.Included ||
                    this.Included != null &&
                    this.Included.SequenceEqual(other.Included)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.Included != null)
                    hash = hash * 59 + this.Included.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
