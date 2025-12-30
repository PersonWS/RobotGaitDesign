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

        public abstract List< byte[]> AnalysisData(byte[] sourceData);



    }
}
