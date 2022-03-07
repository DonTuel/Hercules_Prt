using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStructures
{
    public struct CustomFieldValue
    {
        public string fieldName;
        public string fieldValue;
    }

    public struct CustomQualificationData
    {
        public bool mustExist;
        public int line;
        public int column;
        public List<string> values;
    }
}
