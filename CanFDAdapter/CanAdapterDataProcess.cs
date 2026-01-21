using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public abstract class CanAdapterDataProcess
    {
        CanAdapterEntity _canAdapterEntity;
        public CanAdapterDataProcess(CanAdapterEntity entity)
        { 
            this._canAdapterEntity = entity;
        }

        public abstract CanAdapterReceivedDataEntity AnalysisMotorRetData(CanAdapterReceivedDataEntity sourceData);
        /// <summary>
        /// 生成发送给电机的数据
        /// </summary>
        /// <param name="sourceData"></param>
        /// <returns></returns>
        public abstract List<byte[]> GenerateSendMotorData(List<byte[]> sourceData);

    }
}
