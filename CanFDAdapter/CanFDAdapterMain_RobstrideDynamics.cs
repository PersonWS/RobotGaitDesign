using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanFDAdapterMain_RobstrideDynamics : CanFDAdapterMain
    {

        public CanFDAdapterMain_RobstrideDynamics(CanAdapterEntity canAdapterEntity) : base(canAdapterEntity)
        {

        }

        /// <summary>
        /// 在调用回调前先检查报文的合法性
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        protected override byte[] BeforeMessageReceiveEventInvoke(byte[] b)
        {
            byte[] send = new byte[] { };
            lock (_lock)
            {
                base._buffer.AddRange(b);

                if (b.Length<2)
                {
                    return new byte[] { };
                }
                for (int i = 0; i < _buffer.Count; i++)
                {
                    if (_buffer[i] == 65 && _buffer[i+1] == 84)//检查报文头部
                    {
                        if (_buffer.Count - i > 16)
                        {
                            send = _buffer.Skip(i).Take(((_buffer.Count - i ) /17) * 17).ToArray();//切割出整段报文
                            _buffer= _buffer.Skip(i+send.Length).Take(_buffer.Count-send.Length-i).ToList();

                        }
                    }
                }
                if (send?.Length<1&&base._buffer.Count>33)//如果没有解析出来数据，并且已留存的报文超过17*2-1
                {
                    base._buffer.Clear();//清除数据
                }
            }
            return send;
        }


    }
}
