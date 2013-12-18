using System;
namespace gotom.xcomm
{
    public interface IChannel
    {
        event CommonHandler<ChannelState> StateHandler;
        event CommonHandler<byte[]> ReceiveHandler;
        string Id { get; }
        ChannelState State { get; }

        bool Connected();
        void Connect();
        void Close();
        void Write(byte[] bytes);
       
    }
}
