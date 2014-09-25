using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom.Models
{
    public class ScenarioContentItem
    {

    }
    /// <summary>
    /// 情景。
    /// </summary>
    public class Scenario
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("created_at")]
        public DateTime DateCreated { get; set; }
        [JsonProperty("updated_at")]
        public DateTime DateUpdated { get; set; }

        public ScenarioContentItem[] ContentItems { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                var result = 0;
                result = (result * 397) ^ this.Id;
                result = (result * 397) ^ (this.Name ?? "").GetHashCode();
                result = (result * 397) ^ this.DateCreated.GetHashCode();
                result = (result * 397) ^ this.DateUpdated.GetHashCode();
                return result;
            }
        }
        public override bool Equals(object obj)
        {
            Scenario target = obj as Scenario;
            if(target == null)
                return false;

            return (this.Id == target.Id && this.Name == target.Name && this.DateCreated == target.DateCreated && this.DateUpdated == target.DateUpdated);
        }

        public void CopyFrom(Scenario value)
        {
            if (this.Id != value.Id)
                throw new ArgumentException("目标ID不一致。");

            this.Name = value.Name;
            this.DateCreated = value.DateCreated;
            this.DateUpdated = value.DateUpdated;
        }
    }
}
