// Coded by chuangen http://chuangen.name.

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
        /// <summary>
        /// ID
        /// </summary>
        public int id  { get; set; }
        /// <summary>
        /// 情景ID
        /// </summary>
        public int scenario_id  { get; set; }
        /// <summary>
        /// 类别，目前可填写ScenarioContentItems::Bulb或ScenarioContentItems::EcoTower
        /// </summary>
        public string type  { get; set; }
        /// <summary>
        /// 目标开／关状态
        /// </summary>
        public bool turned_on  { get; set; }
        /// <summary>
        /// 目标灯泡的ID
        /// </summary>
        public int bulb_id  { get; set; }
        /// <summary>
        /// 目标灯泡的目标亮度
        /// </summary>
        public float brightness  { get; set; }
        /// <summary>
        /// 目标灯泡的目标色温
        /// </summary>
        public float hue  { get; set; }
        /// <summary>
        /// 目标EcoTower的ID
        /// </summary>
        public int? eco_tower_id  { get; set; }
        /// <summary>
        /// 目标EcoTower的目标温度
        /// </summary>
        public int? target_temperature  { get; set; }
        /// <summary>
        /// 记录的创建日期
        /// </summary>
        public DateTime? created_at  { get; set; }
        /// <summary>
        /// 记录的更新日期
        /// </summary>
        public DateTime? updated_at  { get; set; }
    }
    /// <summary>
    /// 情景。
    /// </summary>
    public class Scenario
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// 记录的创建日期
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// 记录的更新日期
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime DateUpdated { get; set; }
        [JsonProperty("scenario_content_items")]
        /// <summary>
        /// 场景内容，一个API::ScenarioContentItem的数组
        /// </summary>
        [JsonConverter(typeof(ConcreteTypeConverter<ScenarioContentItem[]>))]
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
