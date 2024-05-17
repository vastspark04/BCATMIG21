using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAircraftTemplateMIG21
{
    public class AircraftInfo
    {

        //READ ME, IMPORTANT!!!!!!!!
        //You must change HarmonyId in order for your custom aircraft mod to be compatible with other aircraft mods
        public const string HarmonyId = "lului.mig21";

        
        
        //The name of the aircraft specified in the External Vehicle Info Component
       
        public const string vehicleName = "MIG-21 Fishbed";
       
        //Names of the prefab name you created and the name of the Assetbundle that you created
        public const string AircraftAssetbundleName = "mig21";
        public const string AircraftPrefabName = "MIG21"; 


    }
}
