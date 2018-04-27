#region License

//   Copyright 2014 Elton FAN (eltonfan@live.cn, http://elton.io)
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License. 

#endregion

using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elton.Phantom
{
    using Bulb = Models.Version1.Bulb;
    using Scenario = Models.Version1.Scenario;

    partial class PhantomClientEx
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
