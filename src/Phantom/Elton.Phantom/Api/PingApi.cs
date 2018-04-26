#region License

//   Copyright 2014 Elton FAN
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

using System;

namespace Elton.Phantom
{
    partial class PhantomApi
    {
        public void Ping(int apiVersion = 2)
        {
            string result = this.Get<string>(apiVersion, "ping.json");
            if (apiVersion == 1 && result == "pong")
                return;
            if (apiVersion == 2 && result == "pong v2")
                return;

            throw new Exception($"Ping-v{apiVersion} ERROR, response: {result}.");
        }

        public bool TryPing(int apiVersion = 2)
        {
            try
            {
                Ping(apiVersion);

                return true;
            }
            catch(Exception ex)
            {
                log.Error("Failed to Ping.", ex);

                return false;
            }
        }
    }
}
