using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioManager
{
    public class AudioManager
    {
        private MMDevice device;
        private MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();

        /// <summary>
        /// 取得所有音频输出设备
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MMDevice> GetActiveSpeakers()
        {
            return DevEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            /*
             foreach (var de in DevEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
             {
                 Console.WriteLine($"FriendlyName={de.FriendlyName}, ID={de.ID}");
             }
             */
        }
        /// <summary>
        /// 取得默认音频输出设备
        /// </summary>
        /// <returns></returns>
        public MMDevice GetDefaultSpeaker() => DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
        /// <summary>
        /// 设置默认音频输出设备音量
        /// </summary>
        /// <param name="scalar">音量范围0.00f - 1.0f (0 - 100)</param>
        public void SetDefaultSpeakerVolumeLevelScalar(float scalar)
        {
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            device.AudioEndpointVolume.MasterVolumeLevelScalar = scalar;
        }
        /// <summary>
        /// 设置音频输入输出设备音量
        /// </summary>
        /// <param name="id">设备ID</param>
        /// <param name="scalar">音量范围0.00f - 1.0f (0 - 100)</param>
        public void SetDeviceVolumeLevelScalar(string id, float scalar)
        {
            var dev = DevEnum.GetDevice(id);
            dev.AudioEndpointVolume.MasterVolumeLevelScalar = scalar;
        }
        /// <summary>
        /// 设置默认音频输出设备静音|正常
        /// </summary>
        /// <param name="isMute">是否静音</param>
        public void SetDefaultSpeakerMute(bool isMute)
        {
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            device.AudioEndpointVolume.Mute = isMute;
        }
        /// <summary>
        /// 设置指定音频输入输出设备静音|正常
        /// </summary>
        /// <param name="id">设备ID</param>
        /// <param name="isMute">是否静音</param>
        public void SetDeviceMute(string id, bool isMute)
        {
            var dev = DevEnum.GetDevice(id);
            dev.AudioEndpointVolume.Mute = isMute;
        }
        /// <summary>
        /// 取得所有音频输入设备
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MMDevice> GetActiveInputs()
        {
            return DevEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            /*
             foreach (var de in DevEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active))
             {
                 Console.WriteLine($"FriendlyName={de.FriendlyName}, ID={de.ID}");
             }
             */
        }
        /// <summary>
        /// 取得默认音频输入设备
        /// </summary>
        /// <returns></returns>
        public MMDevice GetDefaultInput() => DevEnum.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
        /// <summary>
        /// 设置默认音频输入设备音量
        /// </summary>
        /// <param name="scalar">音量范围0.00f - 1.0f (0 - 100)</param>
        public void SetDefaultInputVolumeLevelScalar(float scalar)
        {
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            device.AudioEndpointVolume.MasterVolumeLevelScalar = scalar;
        }
        /// <summary>
        /// 设置默认音频输入设备静音|正常
        /// </summary>
        /// <param name="isMute">是否静音</param>
        public void SetDefaultInputMute(bool isMute)
        {
            device = DevEnum.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
            device.AudioEndpointVolume.Mute = isMute;
        }
    }
}
