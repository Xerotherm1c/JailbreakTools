using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shshPatri0tS {

    public class DeviceProfile {

        private bool mSchedulingEnabled = false;

        private string mName;
        private string mECID;

        private string mDeviceType;
        private string mIdentifier;
        private string mInternalName;

        private string mApnonce;
        private string[] mApnonceList;


        public DeviceProfile(string deviceType = "", string identifier = "", string internalName = "") {

            mDeviceType = deviceType;
            mIdentifier = identifier;
            mInternalName = internalName;

        }

        public DeviceProfile(string name, string[] lines) {

            mName = name;

            foreach (string line in lines) {

                string[] keypair = line.Split(':');

                switch (keypair[0]) {

                    case "SchedulingEnabled":

                        mSchedulingEnabled = bool.Parse(keypair[1]);
                        break;

                    case "ECID":

                        mECID = keypair[1];
                        break;

                    case "DeviceType":

                        mDeviceType = keypair[1];
                        break;

                    case "Identifier":

                        mIdentifier = keypair[1];
                        break;

                    case "InternalName":

                        mInternalName = keypair[1];
                        break;

                    case "Apnonce":

                        mApnonce = keypair[1];
                        break;

                    case "ApnonceList":

                        mApnonceList = keypair[1].Split(';');
                        break;

                    default:

                        break;

                }

            }

        }


        public bool SchedulingEnabled { get { return mSchedulingEnabled; } set { mSchedulingEnabled = value; } }

        public string Name { get { return mName; } set { mName = value; } }
        public string ECID { get { return mECID; } set { mECID = value; } }

        public string DeviceType { get { return mDeviceType; } set { mDeviceType = value; } }
        public string Identifier { get { return mIdentifier; } set { mIdentifier = value; } }
        public string InternalName { get { return mInternalName; } set { mInternalName = value; } }

        public string Apnonce { get { return mApnonce; } set { mApnonce = value; } }
        public string[] ApnonceList { get { return mApnonceList; } set { mApnonceList = value; } }

    }

}
