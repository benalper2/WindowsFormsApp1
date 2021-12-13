using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Holds information about a single calculator operation
    /// </summary>
    public class Operation
    {
        #region Public Properties

        //The left side of the operation
        public String LeftSide { get; set; }

        //The right side of the operation
        public String RightSide { get; set; }

        //THe type of operation to perform
        public OperationType OperationType { get; set; }

        //The inner operation to be performed
        public Operation InnerOperation { get; set; }

        #endregion

        #region Constructor
        public Operation()
        {
            this.LeftSide = string.Empty;
            this.RightSide = string.Empty;
        }
        #endregion
    }
}
