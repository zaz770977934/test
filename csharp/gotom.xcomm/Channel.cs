using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace gotom.xcomm
{

    public abstract class Channel : IChannel
    {

        #region IChannel 成员

        public event CommonHandler<ChannelState> StateHandler;

        public event CommonHandler<byte[]> ReceiveHandler;

        protected virtual void OnStateHandler(ChannelState State)
        {
            if (this.State != State)
            {
                this.State = State;
                if (StateHandler != null)
                {
                    StateHandler(this, new CommonEventArgs<ChannelState>(State));
                }
            }
        }

        protected virtual void OnReceiveHandler(byte[] buffer)
        {
            if (ReceiveHandler != null)
            {
                ReceiveHandler(this, new CommonEventArgs<byte[]>(buffer));
            }
        }

        public string Id
        {
            get;
            protected set;
        }

        public ChannelState State
        {
            get;
            private set;
        }

        public abstract void Connect();

        public virtual bool Connected()
        {
            return State == ChannelState.Connected;
        }

        public abstract void Close();

        public abstract void Write(byte[] bytes);

        #endregion
    }

    #region 通道状态

    /// <summary>
    /// 通道状态
    /// </summary>
    public enum ChannelState
    {
        /// <summary>
        /// 未连接
        /// </summary>
        None = 0x00,

        /// <summary>
        /// 连接中
        /// </summary>
        Connecting = 0x02,

        /// <summary>
        /// 连接成功
        /// </summary>
        Connected = 0x01,

        /// <summary>
        /// 连接失败
        /// </summary>
        Failed = 0xFF,

        /// <summary>
        /// 断开连接
        /// </summary>
        Disconnect = 0xEE,

        /// <summary>
        /// 主动连接关闭
        /// </summary>
        Close = 0xCC,

    }

    #endregion
}
