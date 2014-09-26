using Mavplus.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mavplus.Phantom
{
    partial class PhantomClient
    {
        /// <summary>
        /// 发现新灯泡。
        /// </summary>
        public event EventHandler<BulbEventArgs> NewBulb;
        /// <summary>
        /// 灯泡被移除。
        /// </summary>
        public event EventHandler<BulbEventArgs> BulbRemoved;
        /// <summary>
        /// 灯泡状态发生变化。
        /// </summary>
        public event EventHandler<BulbEventArgs> BulbStateChanged;

        /// <summary>
        /// 发现新场景。
        /// </summary>
        public event EventHandler<ScenarioEventArgs> NewScenario;
        /// <summary>
        /// 场景被移除。
        /// </summary>
        public event EventHandler<ScenarioEventArgs> ScenarioRemoved;
        /// <summary>
        /// 场景状态发生变化。
        /// </summary>
        public event EventHandler<ScenarioEventArgs> ScenarioStateChanged;
    }

    public class BulbEventArgs : EventArgs
    {
        public Bulb Bulb { get; private set; }
        public BulbEventArgs(Bulb bulb)
        {
            this.Bulb = bulb;
        }
    }
    public class ScenarioEventArgs : EventArgs
    {
        public Scenario Scenario { get; private set; }
        public ScenarioEventArgs(Scenario scenario)
        {
            this.Scenario = scenario;
        }
    }
}
