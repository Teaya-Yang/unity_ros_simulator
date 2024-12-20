//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;
using RosMessageTypes.Std;

namespace RosMessageTypes.HiperlabRostools
{
    [Serializable]
    public class Simulator_truthMsg : Message
    {
        public const string k_RosMessageName = "hiperlab_rostools/simulator_truth";
        public override string RosMessageName => k_RosMessageName;

        public HeaderMsg header;
        public long vehicleID;
        public double posx;
        public double posy;
        public double posz;
        public double velx;
        public double vely;
        public double velz;
        public double attyaw;
        public double attpitch;
        public double attroll;
        public double attq0;
        public double attq1;
        public double attq2;
        public double attq3;
        public double angvelx;
        public double angvely;
        public double angvelz;

        public Simulator_truthMsg()
        {
            this.header = new HeaderMsg();
            this.vehicleID = 0;
            this.posx = 0.0;
            this.posy = 0.0;
            this.posz = 0.0;
            this.velx = 0.0;
            this.vely = 0.0;
            this.velz = 0.0;
            this.attyaw = 0.0;
            this.attpitch = 0.0;
            this.attroll = 0.0;
            this.attq0 = 0.0;
            this.attq1 = 0.0;
            this.attq2 = 0.0;
            this.attq3 = 0.0;
            this.angvelx = 0.0;
            this.angvely = 0.0;
            this.angvelz = 0.0;
        }

        public Simulator_truthMsg(HeaderMsg header, long vehicleID, double posx, double posy, double posz, double velx, double vely, double velz, double attyaw, double attpitch, double attroll, double attq0, double attq1, double attq2, double attq3, double angvelx, double angvely, double angvelz)
        {
            this.header = header;
            this.vehicleID = vehicleID;
            this.posx = posx;
            this.posy = posy;
            this.posz = posz;
            this.velx = velx;
            this.vely = vely;
            this.velz = velz;
            this.attyaw = attyaw;
            this.attpitch = attpitch;
            this.attroll = attroll;
            this.attq0 = attq0;
            this.attq1 = attq1;
            this.attq2 = attq2;
            this.attq3 = attq3;
            this.angvelx = angvelx;
            this.angvely = angvely;
            this.angvelz = angvelz;
        }

        public static Simulator_truthMsg Deserialize(MessageDeserializer deserializer) => new Simulator_truthMsg(deserializer);

        private Simulator_truthMsg(MessageDeserializer deserializer)
        {
            this.header = HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.vehicleID);
            deserializer.Read(out this.posx);
            deserializer.Read(out this.posy);
            deserializer.Read(out this.posz);
            deserializer.Read(out this.velx);
            deserializer.Read(out this.vely);
            deserializer.Read(out this.velz);
            deserializer.Read(out this.attyaw);
            deserializer.Read(out this.attpitch);
            deserializer.Read(out this.attroll);
            deserializer.Read(out this.attq0);
            deserializer.Read(out this.attq1);
            deserializer.Read(out this.attq2);
            deserializer.Read(out this.attq3);
            deserializer.Read(out this.angvelx);
            deserializer.Read(out this.angvely);
            deserializer.Read(out this.angvelz);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.Write(this.vehicleID);
            serializer.Write(this.posx);
            serializer.Write(this.posy);
            serializer.Write(this.posz);
            serializer.Write(this.velx);
            serializer.Write(this.vely);
            serializer.Write(this.velz);
            serializer.Write(this.attyaw);
            serializer.Write(this.attpitch);
            serializer.Write(this.attroll);
            serializer.Write(this.attq0);
            serializer.Write(this.attq1);
            serializer.Write(this.attq2);
            serializer.Write(this.attq3);
            serializer.Write(this.angvelx);
            serializer.Write(this.angvely);
            serializer.Write(this.angvelz);
        }

        public override string ToString()
        {
            return "Simulator_truthMsg: " +
            "\nheader: " + header.ToString() +
            "\nvehicleID: " + vehicleID.ToString() +
            "\nposx: " + posx.ToString() +
            "\nposy: " + posy.ToString() +
            "\nposz: " + posz.ToString() +
            "\nvelx: " + velx.ToString() +
            "\nvely: " + vely.ToString() +
            "\nvelz: " + velz.ToString() +
            "\nattyaw: " + attyaw.ToString() +
            "\nattpitch: " + attpitch.ToString() +
            "\nattroll: " + attroll.ToString() +
            "\nattq0: " + attq0.ToString() +
            "\nattq1: " + attq1.ToString() +
            "\nattq2: " + attq2.ToString() +
            "\nattq3: " + attq3.ToString() +
            "\nangvelx: " + angvelx.ToString() +
            "\nangvely: " + angvely.ToString() +
            "\nangvelz: " + angvelz.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
