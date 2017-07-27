using System;
using Xamarin.Forms;

namespace HelloMorning.CoreAssets.Classes.Tools
{
    public class MiscTools
    {
        public MiscTools miscTools = new MiscTools();

        public DeviceType deviceType;

        public MiscTools()
        {
        }

        public enum DeviceType
        {
            Unknown,
            IOS,
            Android,
            Other
        };

        public DeviceType GetDeviceType()
        {
            

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    deviceType = DeviceType.IOS;
                    break;

				case Device.Android:
					deviceType = DeviceType.Android;
					break;

				case Device.WinPhone:
					deviceType = DeviceType.Other;
					break;

                default:
                    deviceType = DeviceType.Unknown;
					break;

            }

            return deviceType;
        }
    }
}
