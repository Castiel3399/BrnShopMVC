using System;
using System.Runtime.Serialization;

namespace BrnShop.Core
{
    /// <summary>
    /// BrnShop�쳣��
    /// </summary>
    [Serializable]
    public class BSPException : ApplicationException
    {
        public BSPException() { }

        public BSPException(string message) : base(message) { }

        public BSPException(string message, Exception inner) : base(message, inner) { }

        protected BSPException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
