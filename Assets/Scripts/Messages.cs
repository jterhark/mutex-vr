using UnityEngine.Networking;

namespace NetworkMessages {
    public static class MessageTypes {
        public const short PositionUpdate = 1024;
    }
    
    public enum PositionType{None = 0, Soldier = 1, Enemy = 2}
    
    public class PositionMessage : MessageBase {
        public PositionType Type;
        public float X;
        public float Y;
        public float Z;
    };
}
    
