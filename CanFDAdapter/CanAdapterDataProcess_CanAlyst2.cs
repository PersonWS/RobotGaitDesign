using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanFDAdapter
{
    public class CanAdapterDataProcess_CanAlyst2 : CanAdapterDataProcess
    {
        public CanAdapterDataProcess_CanAlyst2(CanAdapterEntity entity)
            : base(entity)
        {
        }
        public override CanAdapterReceivedDataEntity AnalysisMotorRetData(CanAdapterReceivedDataEntity sourceData)
        {
            return sourceData;
        }

        public override List<byte[]> GenerateSendMotorData(List<byte[]> sourceData)
        {
            return sourceData;
            return null;
        }









    }
}
