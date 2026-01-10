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
        protected override List<byte[]> BeforeMessageReceiveEventInvoke(byte[] b)
        {
            List<byte[]> list = new List<byte[]>();
            byte[] send = new byte[] { };
            lock (_lock)
            {
                base._buffer.AddRange(b);
                try
                {
                    if (b.Length < 2)
                    {
                        return new List<byte[]> { };
                    }
                    int processTag = 0;//标记处理到第多少个字节了
                    for (int i = 0; i < _buffer.Count-2; i++)
                    {
                        if (_buffer[i] == 65 && _buffer[i + 1] == 84)//检查报文头部
                        {
                            if (_buffer.Count - i > 16)
                            {
                                send = _buffer.Skip(i).Take(9 + (_buffer[i + 6])).ToArray();//切割出整段报文
                                list.Add(send);
                                i = i + send.Length - 1;
                            }
                        }
                        processTag = i+1;
                    }
                    ////处理剩余字符
                    //log.Error($"原始数据长度：{base._buffer.Count} 添加条数：{list.Count}");
                    _buffer = _buffer.Skip(processTag).Take(_buffer.Count - processTag).ToList();//保留剩余字符，流转到下一次

                    if (_buffer.Count < 1 && base._buffer.Count > 33)//如果没有解析出来数据，并且已留存的报文超过17*2-1
                    {
                        base._buffer.Clear();//清除数据
                        log.Error($"存在异常未处理的数据，长度:{_buffer.Count}, 内容:{BitConverter.ToString(base._buffer.ToArray())}");
                    }

                    return list;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }


    }
}
