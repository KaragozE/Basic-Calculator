using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{   
    /// <summary>
    /// Holds information about a single calculator operaiton
    /// </summary>
    public class Operation
    {
        #region Public Properties
        /// <summary>
        /// The left side of the operation
        /// </summary>
        public string LeftSide { get; set; }
        
        /// <summary>
        /// The right side of the operation 
        /// </summary>
        public string RightSide { get; set; }

        /// <summary>
        /// The type of the operation to perform
        /// </summary>
        public OperationType OperationType { get; set; }

        /// <summary>
        /// The inner operation to be performed initially before this operation
        /// </summary>
        public OperationType InnerOperation { get; set; }
        #endregion

        public Operation()
        {

        }
    }
}
