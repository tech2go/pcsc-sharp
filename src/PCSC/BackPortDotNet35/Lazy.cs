using System;
using System.Collections.Generic;
using System.Text;

namespace PCSC.BackPortDotNet35
{
    public class Lazy<T>
    {
        private readonly Func<T> initializer;
        private bool isValueCreated;
        private T value;

        public Lazy(Func<T> initializer)
        {
            this.initializer = initializer ?? throw new ArgumentNullException("initializer");
        }

        public bool IsValueCreated
        {
            get { return isValueCreated; }
        }

        public T Value
        {
            get
            {
                if (!isValueCreated)
                {
                    value = initializer();
                    isValueCreated = true;
                }
                return value;
            }
        }
    }
}
