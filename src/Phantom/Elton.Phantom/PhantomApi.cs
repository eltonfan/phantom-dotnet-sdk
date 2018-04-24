using Elton.Phantom.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elton.Phantom
{
    public class PhantomApi
    {
        static readonly Common.Logging.ILog log = Common.Logging.LogManager.GetLogger(typeof(PhantomApi));

        /// <summary>
        /// 全关的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOff = 0x0000;
        /// <summary>
        /// 全开的情景ID。
        /// </summary>
        const int SCENARIO_ID_AllOn = 0xFFFF;
        readonly Version1.PhantomAPI api1 = null;
        readonly Version2.PhantomAPI api2 = null;


        public PhantomApi(PhantomConfiguration config)
        {
            this.api1 = new Version1.PhantomAPI(config);
            this.api2 = new Version2.PhantomAPI(config);
        }

        public bool Ping()
        {
            return api1.Ping();
        }

        public void SetCredentials(string token)
        {
            this.api1.SetCredentials(token);
            this.api2.SetCredentials(token);
        }

        public User GetUser()
        {
            return api1.GetUser();
        }

        public TokenV2 RefreshToken(string refreshToken)
        {
            return this.api2.RefreshToken(refreshToken);
        }

        public void SetScenario(Scenario scenario)
        {
            if (scenario.Id == SCENARIO_ID_AllOff)//实际上是全关
                api1.SetScenarioAllOff();
            else if (scenario.Id == SCENARIO_ID_AllOn)
                api1.SetScenarioAllOn();
            else
                api1.SetScenario(scenario.Id);
        }

        public void SetScenario(int scenarioId)
        {
            if (scenarioId == SCENARIO_ID_AllOff)//实际上是全关
                api1.SetScenarioAllOff();
            else if (scenarioId == SCENARIO_ID_AllOn)
                api1.SetScenarioAllOn();
            else
                api1.SetScenario(scenarioId);
        }

        public void SetBulb(Bulb bulb, bool isOn)
        {
            if (isOn)
                api1.SetBulbSwitchOn(bulb.Id);
            else
                api1.SetBulbSwitchOff(bulb.Id);
        }
        public void SetBulb(int bulbId, bool isOn)
        {
            if (isOn)
                api1.SetBulbSwitchOn(bulbId);
            else
                api1.SetBulbSwitchOff(bulbId);
        }
        public void SetBulb(Bulb bulb, float brightness, float hue)
        {
            api1.SetBulbTune(bulb.Id, brightness, hue);
        }
        public void SetBulb(int bulbId, float brightness, float hue)
        {
            api1.SetBulbTune(bulbId, brightness, hue);
        }

        public Scenario[] GetScenarios(int zoneId, bool hasDetails = false)
        {
            return api1.GetScenarios(0, hasDetails);
        }

        public Bulb[] GetBulbs(bool hasDetails = false)
        {
            return api1.GetBulbs(hasDetails);
        }

        public Bulb GetBulb(int id)
        {
            return api1.GetBulb(id);
        }
        public void SetBulbSwitchOn(int bulbId)
        {
            api1.SetBulbSwitchOn(bulbId);
        }
        public void SetBulbSwitchOff(int bulbId)
        {
            api1.SetBulbSwitchOff(bulbId);
        }
        public void SetBulbTune(int bulbId, float brightness, float hue)
        {
            api1.SetBulbTune(bulbId, brightness, hue);
        }
        public void SetScenarioAllOff()
        {
            api1.SetScenarioAllOff();
        }
        public void SetScenarioAllOn()
        {
            api1.SetScenarioAllOn();
        }

        public List<UserLog> GetUserLog(string cursor, int count, out string nextCursor)
        {
            List<UserLog> result = api2.GetUserLog(cursor, count, out nextCursor);
            return result;
        }

        public void GetDeviceLog()
        {
            string nextCursor;
            List<DeviceLog> result = api2.GetDeviceLog("door_sensor", null, null, 20, out nextCursor);
        }

        public TokenV2 CreateToken(string authorizationCode)
        {
            return api2.CreateToken(authorizationCode);
        }


        public void UpdateScenarioMode(int id, string name, byte mode)
        {
            var result = api1.UpdateScenario(id, name,
                new[]
                {
                    new
                    {
                        generic_module_id = 741,
                        info = string.Format("[{{\"type\":\"mode\",\"index\":0,\"value\":{0}}}]", mode),
                    },
                });
        }
        public void UpdateScenarioData(int id, string name, int data)
        {
            var old = api1.GetScenario(id);

            var list = new List<object>();
            bool hasData = false;
            foreach (var item in old.ContentItems)
            {
                if (item.generic_module_id != 741 || hasData)
                {//不正确，或者已经存在记录，则删除
                    list.Add(
                            new
                            {
                                id = item.id,
                                _destroy = true,
                            }
                        );
                }
                else
                {
                    hasData = true;
                    list.Add(
                            new
                            {
                                id = item.id,
                                generic_module_id = 741,
                                info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                            }
                        );
                }
            }
            if (!hasData)
            {//添加记录
                list.Add(
                    new
                    {
                        generic_module_id = 741,
                        info = string.Format("[{{\"type\":\"data\",\"index\":0,\"value\":{0}}}]", data),
                    });
            }


            Scenario result = api1.UpdateScenario(id, name, list.ToArray());
        }
    }
}
