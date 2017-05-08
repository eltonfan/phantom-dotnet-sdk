using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Elton.Phantom
{
    public class PhantomScopes
    {
        //2017-05-07 ALL SCOPES
        //read_user write_user monitor_user
        //read_router writer_router monitor_router
        //read_pixel_pro write_pixel_pro monitor_pixel_pro
        //read_generic_module write_generic_module monitor_generic_module
        //read_door_accessor write_door_accessor monitor_door_accessor
        //read_wall_switch write_wall_switch monitor_wall_switch
        //read_infrared_sensor write_infrared_sensor monitor_infrared_sensor
        //read_door_sensor write_door_sensor monitor_door_sensor
        //read_bulb write_bulb monitor_bulb
        //read_switch write_switch monitor_switch
        //read_snp_inside write_snp_inside monitor_snp_inside
        //read_iodetector write_iodetector monitor_iodetector
        //read_irda_hub write_irda_hub monitor_irda_hub
        //read_ac_controller write_ac_controller monitor_ac_controller
        //read_upnp write_upnp
        //apply_scenario write_scenario
        //monitor_app
        //monitor_occupy
        //monitor_betech
        //monitor_huohe
        //monitor_lumen

        public static string GetString()
        {
            string[] arrayScopes = new string[]
            {

                "read_user","write_user","monitor_user",
                "read_router","writer_router","monitor_router",
                "read_pixel_pro","write_pixel_pro","monitor_pixel_pro",
                "read_generic_module","write_generic_module","monitor_generic_module",
                "read_door_accessor","write_door_accessor","monitor_door_accessor",
                "read_wall_switch","write_wall_switch","monitor_wall_switch",
                //"read_infrared_sensor","write_infrared_sensor","monitor_infrared_sensor",
                "read_door_sensor","write_door_sensor","monitor_door_sensor",
                "read_bulb","write_bulb","monitor_bulb",
                "read_switch","write_switch","monitor_switch",
                //"read_iodetector","write_iodetector","monitor_iodetector",
                //"read_irda_hub","write_irda_hub","monitor_irda_hub",
                //"read_ac_controller","write_ac_controller","monitor_ac_controller",
                //"read_upnp","write_upnp",
                "apply_scenario","write_scenario",

            };
            return string.Join("+", arrayScopes);
        }
    }
}
