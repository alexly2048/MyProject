using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaDataProcess.Data
{
    public class TransferData
    {
        private IEnumerable<TransferFunctionDataList> functionDataList;
        private TransferFunctionFrequencyList frequencyList;
        public IEnumerable<TransferFunctionDataList> FunctionDataList
        {
            get { return functionDataList; }
            set { functionDataList = value; }
        }

        public TransferFunctionFrequencyList FrequencyList
        {
            get { return frequencyList; }
            set { frequencyList = value; }
        }

        public TransferFunctionColEnum SelectedCol { get; set; }

        public double CalculateG(double fd, TransferFunctionDataList list)
        {
            throw new NotImplementedException();
        }
    }
}
